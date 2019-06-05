using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GG.Classes;
using Microsoft.ApplicationBlocks.Data;
using Extensions;
using SlickControls.Panels;

namespace GG
{
	public static class SqlHandler
	{
		public static string ConnectionString = ConfigurationManager.ConnectionStrings["GGdbConnectionString"].ConnectionString;

		public static List<Customer> GetCustomers(bool complete = true)
		{
			var dt = new DataTable();
			if (complete)
				dt.Load(SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "SELECT *, LastInvoiceDate = (SELECT TOP 1 [Date] From [Invoices] WHERE CustomerID = [Customer].[ID] ORDER BY [Date] DESC) FROM [Customer]"));
			else
				dt.Load(SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "SELECT [ID],[FirstName],[LastName] FROM [Customer]"));
			return dt.DataTableToList<Customer>();
		}

		public static object[] GetDivisions()
		{
			var dt = new DataTable();
			dt.Load(SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "SELECT DISTINCT [Division] FROM [Customer]"));
			return dt.Rows.Cast<DataRow>().Select(x => x[0]).Where(x => x != DBNull.Value && !string.IsNullOrWhiteSpace((string)x)).ToArray();
		}

		public static object[] GetInvoiceYears()
		{
			var dt = new DataTable();
			dt.Load(SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "SELECT DISTINCT YEAR(Date) FROM [Invoices]"));
			return new object[] { -1 }.Concat(dt.Rows.Cast<DataRow>().Select(x => x[0])).ToArray();
		}

		public static List<Invoice> GetInvoices(Customer customer)
		{
			var custs = GetCustomers(false);

			var dt = new DataTable();

			dt.Load(SqlHelper.ExecuteReader(ConnectionString, "GetInvoices", customer?.ID ?? -1));

			var list = dt.DataTableToList<Invoice>();
			list.ForEach(x => x.Customer = custs.FirstThat(y => y.ID == x.CustomerID));

			return list;
		}

		public static double GetInvoicePrice(int customerID, double startingCounter, double endingCounter, DateTime date)
		{
			var i = SqlHelper.ExecuteScalar(ConnectionString, "GetInvoicePrice", customerID, startingCounter, endingCounter, date).ToString().SmartParseD();

			if (i > 0)
				i -= (i % GetRounding());

			return i;
		}

		public static void SaveTarrifs(double kwh, int rounding)
		{
			SqlHelper.ExecuteNonQuery(ConnectionString, "SaveTarrifs", kwh, rounding);
		}

		public static List<AmpereType> GetAmperTypes()
		{
			var dt = new DataTable();
			dt.Load(SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "SELECT * FROM [AmpereTypes]"));
			return dt.DataTableToList<AmpereType>();
		}

		public static void DeleteInvoice(Invoice invoice)
			 => SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, "DELETE FROM Invoice WHERE [ID] = " + invoice.ID);

		public static double GetKwhPrice()
		 => SqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, "SELECT TOP 1 [KwhPrice] FROM [Tarrifs] ORDER BY [Date] DESC")?.ToString().SmartParseD() ?? 0;

		public static int GetRounding()
			=> SqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, "SELECT [Rounding] FROM [Rounding]")?.ToString().SmartParse(1) ?? 250;

		public static List<InvoicePrint> GetInvoicesPrint(IEnumerable<Invoice> enumerable)
		{
			var dt = new DataTable();
			dt.Load(SqlHelper.ExecuteReader(ConnectionString, "GetInvoicesPrint", enumerable.Select(x => x.ID).ListStrings(",")));
			return dt.DataTableToList<InvoicePrint>();
		}

		public static int SaveInvoice(Invoice invoice)
		{
			return SqlHelper.ExecuteScalar(ConnectionString, "SaveInvoice"
				, invoice.ID
				, invoice.CustomerID
				, invoice.Date
				, invoice.EndingCounter
				, invoice.StartingCounter
				, invoice.ExtraCost
				, invoice.ExtraInfo).ToString().SmartParse();
		}

		public static void SaveAmperTypes(IEnumerable<AmpereType> enumerable)
		{
			SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, "DELETE FROM AmpereTypes");

			foreach (var item in enumerable.Where(x => x.Amperes > 0).Distinct(x => x.Amperes))
			{
				SqlHelper.ExecuteNonQuery(ConnectionString, "SaveAmpereType", item.Amperes, item.Value);
			}
		}

		public static Customer GetCustomerById(int id)
		{
			var dt = new DataTable();
			dt.Load(SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, "SELECT * FROM [Customer] WHERE [ID] = " + id));
			return dt.DataTableToList<Customer>().FirstOrDefault();
		}

		public static void SaveCustomer(Customer customer)
		{
			SqlHelper.ExecuteNonQuery(ConnectionString, "SaveCustomer"
				, customer.ID
				, customer.FirstName
				, customer.LastName
				, customer.Mobile
				, customer.Address
				, customer.AmpereNumber
				, customer.CurrentCounter
				, customer.Active
				, customer.Division);
		}

		public static void DeleteCustomer(Customer customer)
				=> SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, "DELETE FROM Customer WHERE [ID] = " + customer.ID);

		#region Converter

		private static readonly IDictionary<Type, ICollection<PropertyInfo>> _Properties =
		 new Dictionary<Type, ICollection<PropertyInfo>>();

		/// <summary>
		/// Converts a DataTable to a list with generic objects
		/// </summary>
		/// <typeparam name="T">Generic object</typeparam>
		/// <param name="table">DataTable</param>
		/// <returns>List with generic objects</returns>
		public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
		{
			try
			{
				var objType = typeof(T);
				ICollection<PropertyInfo> properties;

				lock (_Properties)
				{
					if (!_Properties.TryGetValue(objType, out properties))
					{
						properties = objType.GetProperties().Where(property => property.CanWrite).ToList();
						_Properties.Add(objType, properties);
					}
				}

				var list = new List<T>(table.Rows.Count);

				foreach (var row in table.AsEnumerable())
				{
					var obj = new T();

					foreach (var prop in properties)
					{
						try
						{
							var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
							var safeValue = row[prop.Name] == null ? null : Convert.ChangeType(row[prop.Name], propType);

							prop.SetValue(obj, safeValue, null);
						}
						catch
						{
							// ignored
						}
					}

					list.Add(obj);
				}

				return list;
			}
			catch
			{
				return new List<T>();
			}
		}

		#endregion
	}
}
