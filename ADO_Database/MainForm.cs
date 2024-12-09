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
    /// <summary>
    /// MainForm is the primary interface for managing vehicle data and mileage records
    /// using a SQL Server database. It allows the user to:
    /// - Connect to the database and display connection status.
    /// - Retrieve and display vehicle data in a ListBox.
    /// - Display the selected vehicle's details and its average mileage.
    /// - Add a new vehicle to the database.
    /// </summary>
    public partial class MainForm : Form
    {
        // Properties for database connection
        /// <summary>
        /// Represents an open connection to the SQL Server database.
        /// </summary>
        public SqlConnection Connection { get; }

        // Connection string for SQL Server
        /// <summary>
        /// Connection string to connect to the ADODOTNET database using SQL Server Express.
        /// </summary>
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ADODOTNET;Integrated Security=True";

        /// <summary>
        /// Initializes the MainForm and establishes a connection to the SQL Server database.
        /// Updates the status label based on connection success or failure.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            try
            {
                // Create and open a new database connection
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString;
                Connection.Open();
                statusLable.Text = "Connection Successful";
            }
            catch (Exception ex)
            {
                // Display error message if the connection fails
                statusLable.Text = "Database Connection failed - check Connection String: " + ex.Message;
            }
        }

        /// <summary>
        /// Event handler for ListBox selection changes. Fetches and displays the selected vehicle's
        /// details and its average mileage from the database.
        /// </summary>
        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultListBox.Items.Count > 0)
            {
                try
                {
                    // Extract vehicle details from the selected row
                    string selectedRow = resultListBox.SelectedItem.ToString();
                    string[] fields = selectedRow.Split('|'); // Split the row into fields
                    int carId = int.Parse(fields[0].Trim()); // Assuming ID is the first column

                    // Prepare SQL query to calculate average mileage
                    SqlCommand command = new SqlCommand(
                        @"SELECT AVG(CAST(gasused AS FLOAT) / (endkm - startkm) * 100) AS AverageMileage
                          FROM MILEAGE
                          WHERE car_id = @carId",
                        Connection);

                    // Use parameterized query to avoid SQL injection
                    command.Parameters.AddWithValue("@carId", carId);

                    // Execute query and fetch the result
                    object result = command.ExecuteScalar();

                    // Display vehicle details and calculated mileage
                    vehicleTextBox.Text = fields[1].Trim();
                    if (result != null)
                    {
                        mileAgeTextBox.Text = Math.Round((double)result, 2).ToString();
                    }
                }
                catch (Exception ex)
                {
                    statusLable.Text = "Error fetching average mileage: " + ex.Message;
                }
            }
        }

        /// <summary>
        /// Event handler for the "Get Data" button. Fetches and displays all vehicle records
        /// from the database in the ListBox.
        /// </summary>
        private void getDataButton_Click(object sender, EventArgs e)
        {
            // Clear existing items in the ListBox
            resultListBox.Items.Clear();

            try
            {
                // Execute SQL query to fetch all vehicles
                SqlCommand command = new SqlCommand("SELECT * FROM CARS", Connection);
                SqlDataReader reader = command.ExecuteReader();

                // Iterate through the result set and add rows to the ListBox
                while (reader.Read())
                {
                    string output = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        output += String.Format("{0,-10} | ", reader[i]);
                    }
                    resultListBox.Items.Add(output);
                }

                statusLable.Text = "Database selected successfully";

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                statusLable.Text = "Database operation failed: " + ex.Message;
            }
        }

        /// <summary>
        /// Event handler for the "Add Car" button. Opens a dialog to add a new vehicle to the database
        /// and refreshes the displayed data.
        /// </summary>
        private void addCar_Click(object sender, EventArgs e)
        {
            // Open the AddCar form as a modal dialog
            AddCar form = new AddCar(this);
            form.ShowDialog(this);

            // Refresh the ListBox data
            getDataButton_Click(this, null);
        }
    }
}
