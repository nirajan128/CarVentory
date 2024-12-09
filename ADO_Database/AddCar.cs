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
    /// AddCar form allows the user to add a new vehicle to the database. 
    /// It uses data input from the user to insert a new record into the CARS table.
    /// </summary>
    public partial class AddCar : Form
    {
        // Reference to the parent form
        /// <summary>
        /// Holds a reference to the MainForm that invoked this dialog,
        /// allowing access to the shared database connection.
        /// </summary>
        private MainForm parentForm;

        /// <summary>
        /// Initializes the AddCar form and stores a reference to the parent form.
        /// </summary>
        /// <param name="parent">The instance of MainForm that invoked this dialog.</param>
        public AddCar(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent; // Store the reference to parent form
        }

        /// <summary>
        /// Event handler for the "Add to Database" button click. 
        /// Adds a new car record to the database using the provided details.
        /// </summary>
        private void addToDB_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the SQL INSERT command
                SqlCommand command = new SqlCommand(
                    "INSERT INTO CARS (make, model, modelyear) VALUES (@ParamMake, @ParamModel, @ParamYear)",
                    parentForm.Connection);

                // Define parameters and assign values from input fields
                SqlParameter make = new SqlParameter("@ParamMake", SqlDbType.VarChar)
                {
                    Value = makeTextBox.Text
                };
                SqlParameter model = new SqlParameter("@ParamModel", SqlDbType.VarChar)
                {
                    Value = modelTextBox.Text
                };
                SqlParameter modelYear = new SqlParameter("@ParamYear", SqlDbType.Int)
                {
                    Value = yearNumericUpDown.Value
                };

                // Add parameters to the command
                command.Parameters.Add(make);
                command.Parameters.Add(model);
                command.Parameters.Add(modelYear);

                // Execute the command and check the result
                int result = command.ExecuteNonQuery();

                // Close the form
                this.Close();

                // Notify the user if no records were added
                if (result != 1)
                {
                    MessageBox.Show("No record was added to the database.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display an error message if the operation fails
                MessageBox.Show("Error adding car to database: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for the "Cancel" button click. Closes the AddCar form without making changes.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        /// <summary>
        /// Event handler for the DateChanged event of the MonthCalendar control (if used).
        /// Currently, no functionality is implemented.
        /// </summary>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Placeholder for potential future use
        }

        /// <summary>
        /// Event handler for label click events. 
        /// Currently, no functionality is implemented.
        /// </summary>
        private void label3_Click(object sender, EventArgs e)
        {
            // Placeholder for potential future use
        }

        /// <summary>
        /// Event handler for another label click event. 
        /// Currently, no functionality is implemented.
        /// </summary>
        private void label2_Click(object sender, EventArgs e)
        {
            // Placeholder for potential future use
        }
    }
}
