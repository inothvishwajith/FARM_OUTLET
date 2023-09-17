using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Dashboard_Design
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            lordData();
        }
        public void lordData()
        {
            try
            {
                // Database connection string
                string connectionString = "server=localhost;database=farm;username=root;password=";

                using (var db = new MySqlConnection(connectionString))
                {
                    db.Open();

                    // Create a SQL command to select all users
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users", db))
                    {
                        // Create a data adapter to fetch data
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            // Create a DataTable to hold the data
                            DataTable dataTable = new DataTable();

                            // Fill the DataTable with the data from the database
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView2.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exceptions (e.g., display an error message)
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions (e.g., display an error message)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Check if there is a selected row in the DataGridView.
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected row index.
                int rowIndex = dataGridView2.CurrentCell.RowIndex;

                // Get the value from the "name" column of the selected row.
                string nameToDelete = dataGridView2.Rows[rowIndex].Cells["name"].Value.ToString();

                try
                {
                    using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                    {
                        db.Open();

                        // Create the SQL DELETE statement to delete the record with the selected name.
                        var deleteSql = "DELETE FROM users WHERE name = @name;";

                        // Create a MySqlCommand to execute the DELETE statement.
                        var deleteCmd = new MySqlCommand(deleteSql, db);
                        deleteCmd.Parameters.AddWithValue("@name", nameToDelete);

                        // Execute the SQL DELETE statement.
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Display a success message.
                            MessageBox.Show("Record deleted successfully!");

                            // Remove the selected row from the DataGridView.
                            dataGridView2.Rows.RemoveAt(rowIndex);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the selected name.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }
    }
}
