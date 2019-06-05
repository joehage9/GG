using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GG
{  public partial class printInvoice : Form
    {
        int countID, ampereCount, count, startingCounter, endingCounter, amperePrice, kwhPrice, customerID, counterID, totalAmount;

        string name, lastName, mobileNumber, address;      
        DateTime date;
        
        public printInvoice()
        {
            InitializeComponent(); 
            Data.printInvoice = this;
            this.MdiParent = Data.MainForm;
            this.Dock = DockStyle.Fill;
            Data.MainForm.Size = this.Size;    
            
            try
            {             
                SqlConnection conn = new SqlConnection(Data.connectionString);
                conn.Open();

                SqlCommand cmd = conn.CreateCommand(), cmd1 = conn.CreateCommand(), cmd2 = conn.CreateCommand(), cmd3 = conn.CreateCommand(), cmd4 = conn.CreateCommand(), cmd5 = conn.CreateCommand();
                SqlDataReader dataReader;


                cmd.CommandText = "select c.name, c.lastName, c.mobileNumber, c.address, co.startingCounter, co.endingCounter, co.ampereCount, c.ID, co.ID  " +
                                  "from  customers as c,counters as co " +
                                  "where c.ID=co.customerID and c.ID=@customerID and c.name=@name and c.lastName=@lastName and c.mobileNumber=@mobileNumber";
                cmd.Parameters.AddWithValue("@customerID", Data.customerID);
                cmd.Parameters.AddWithValue("@name", Data.name);
                cmd.Parameters.AddWithValue("@lastName", Data.lastName);
                cmd.Parameters.AddWithValue("@mobileNumber", Data.mobileNumber);

                cmd1.CommandText = "select COUNT(ID)" +
                                   "from invoices";
                countID = (int)cmd1.ExecuteScalar();

                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        name = dataReader.GetString(0);
                        lastName = dataReader.GetString(1);
                        mobileNumber = dataReader.GetString(2);
                        address = dataReader.GetString(3);                                            
                        startingCounter = dataReader.GetInt32(4);                       
                        endingCounter = dataReader.GetInt32(5);                       
                        ampereCount = dataReader.GetInt32(6);
                        customerID = dataReader.GetInt32(7);
                        counterID = dataReader.GetInt32(8);    
                    }
                }

                dataReader.Close();

                cmd2.CommandText = "select COUNT(amperePrice) " +
                                  "from ampereTarrifs " +
                                  "where ampereCount=@ampereCount";
                cmd2.Parameters.AddWithValue("@ampereCount", ampereCount);
                dataReader = cmd2.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        count = dataReader.GetInt32(0);
                    }
                }

                dataReader.Close();

                if (count > 0)
                {
                    cmd3.CommandText = "select amperePrice " +
                                       "from ampereTarrifs " +
                                       "where ampereCount=@ampereCount";
                    cmd3.Parameters.AddWithValue("@ampereCount", ampereCount);

                    dataReader = cmd3.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            amperePrice = dataReader.GetInt32(0);
                        }
                    }

                   
                    dataReader.Close();
                }
                else
                    MessageBox.Show("The price for " + ampereCount + " is none existent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmd4.CommandText = "select kwhPrice " +
                                 "from kwhPrice ";
                dataReader = cmd4.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        kwhPrice = dataReader.GetInt32(0);
                    }
                }

                dataReader.Close();

                

                totalAmount = (endingCounter - startingCounter) * kwhPrice + amperePrice;
                label20.Text = (++countID).ToString();
                label21.Text = name + " " + lastName;
                label25.Text = address;
                label8.Text = startingCounter.ToString() + " KWh";
                label10.Text = endingCounter.ToString() + " KWh";
                label6.Text = ampereCount.ToString() + " A";
                label11.Text = (endingCounter - startingCounter).ToString() + " KWh";
                label16.Text = amperePrice.ToString() + " LBP";
                label14.Text = kwhPrice.ToString() + " LBP";       
                label18.Text = totalAmount.ToString() + " LBP";
                date = dateTimePicker1.Value;
               
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection !\n" + ex);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Data.connectionString);
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO invoices " +
                                 "(customerID, counterID, name, lastName, mobileNumber, address, startingCounter, endingCounter, ampereCount, date, value) " +
                                 "values(@customerID, @counterID, @name, @lastName, @mobileNumber, @address, @startingCounter, @endingCounter, @ampereCount, @date, @value)";
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@counterID", counterID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@startingCounter", startingCounter);
                cmd.Parameters.AddWithValue("@endingCounter", endingCounter);
                cmd.Parameters.AddWithValue("@ampereCount", ampereCount);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@value", totalAmount);

                cmd.ExecuteNonQuery();

                CaptureScreen();
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection !\n" + ex);
            }
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = new Size(this.Size.Width + 100, this.Size.Height - 200);
            memoryImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Data.MainForm.Location.X + 10, Data.MainForm.Location.Y + 65, 0, 0, s);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        

    }
}
