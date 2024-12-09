using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Database
{
    public partial class MainForm : Form
    {
        //Properties for connection
        public SqlConnection Connection {get;}

        //Connection String
        String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ADODOTNET;Integrated Security=True";


        public MainForm()
        {
            InitializeComponent();
            try
            {
                Connection = new SqlConnection(); //creates a new instance of connetion
                Connection.ConnectionString = connectionString; //sets the connection string to the given connection string
                Connection.Open();
                statusLable.Text = "Connection Successful";
            }
            catch (Exception ex) {
                statusLable.Text = "Database Connection failed - check Connection String : " +
ex.Message;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            //Clear any contents in the List box
            resultListBox.Items.Clear();

            try
            {
                //A new instance of sql command, takes two param, first is the query and second is the Sql COnnection
                SqlCommand command = new SqlCommand("SELECT * FROM CARS", Connection);

                // Create new SqlDataReader object and read data from the command.This will be an array
                SqlDataReader reader = command.ExecuteReader();

                //While there is another record present
                while (reader.Read())
                {
                    string output = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    { //field count counts the row of data in reader
                        output += String.Format("{0,-10} | ", reader[i]); //add each formatted data to the output string variable
                    }

                    resultListBox.Items.Add(output);
                }

                //successMessage
                statusLable.Text = "Database selected successfully";

                //Close the reader
                reader.Close();
            }
            catch (Exception ex) {
                statusLable.Text = "Database operation failed: " + ex.Message;
            }



        }
    }
}
