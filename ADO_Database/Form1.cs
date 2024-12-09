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
    }
}
