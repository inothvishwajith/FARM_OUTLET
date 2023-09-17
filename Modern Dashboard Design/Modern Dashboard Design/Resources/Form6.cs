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

namespace Modern_Dashboard_Design.Resources
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            lordData();
        }


        public void lordData()
        {
            // Create a DataTable to hold the retrieved data.
            DataTable dataTable = new DataTable();

            try
            {
                using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                {
                    db.Open();

                    // Create the SQL SELECT statement to retrieve data.
                    var sql = "SELECT name, qty FROM veg;";

                    // Create a MySqlCommand to execute the SELECT statement.
                    var cmd = new MySqlCommand(sql, db);

                    // Create a MySqlDataAdapter to fill the DataTable.
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                // Bind the DataTable to the DataGridView.
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // Create a DataTable to hold the retrieved data.
            DataTable dataTable1 = new DataTable();

            try
            {
                using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                {
                    db.Open();

                    // Create the SQL SELECT statement to retrieve data.
                    var sql = "SELECT name, lml, qty FROM livestock;";

                    // Create a MySqlCommand to execute the SELECT statement.
                    var cmd = new MySqlCommand(sql, db);

                    // Create a MySqlDataAdapter to fill the DataTable.
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable1);
                    }
                }

                // Bind the DataTable to the DataGridView.
                dataGridView2.DataSource = dataTable1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            // Create a DataTable to hold the retrieved data.
            DataTable dataTable2 = new DataTable();

            try
            {
                using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                {
                    db.Open();

                    // Create the SQL SELECT statement to retrieve data.
                    var sql = "SELECT name, qty FROM fruits;";

                    // Create a MySqlCommand to execute the SELECT statement.
                    var cmd = new MySqlCommand(sql, db);

                    // Create a MySqlDataAdapter to fill the DataTable.
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable2);
                    }
                }

                // Bind the DataTable to the DataGridView.
                dataGridView3.DataSource = dataTable2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // Create a DataTable to hold the retrieved data.
            DataTable dataTable3 = new DataTable();

            try
            {
                using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                {
                    db.Open();

                    // Create the SQL SELECT statement to retrieve data.
                    var sql = "SELECT name, lml, qty FROM milk;";

                    // Create a MySqlCommand to execute the SELECT statement.
                    var cmd = new MySqlCommand(sql, db);

                    // Create a MySqlDataAdapter to fill the DataTable.
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable3);
                    }
                }

                // Bind the DataTable to the DataGridView.
                dataGridView4.DataSource = dataTable3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row in the DataGridView.
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row index.
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                // Get the value from the "name" column of the selected row.
                string nameToDelete = dataGridView1.Rows[rowIndex].Cells["name"].Value.ToString();

                // Delete the selected row from the DataGridView.
                dataGridView1.Rows.RemoveAt(rowIndex);

                try
                {
                    using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                    {
                        db.Open();

                        // Create the SQL DELETE statement to delete the record with the selected name.
                        var deleteSql = "DELETE FROM veg WHERE name = @name;";

                        // Create a MySqlCommand to execute the DELETE statement.
                        var deleteCmd = new MySqlCommand(deleteSql, db);
                        deleteCmd.Parameters.AddWithValue("@name", nameToDelete);

                        // Execute the SQL DELETE statement.
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Display a success message.
                            MessageBox.Show("Record deleted successfully!");
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
            




            // Check if there is a selected row in the DataGridView.
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected row index.
                int rowIndex = dataGridView2.CurrentCell.RowIndex;

                // Get the value from the "name" column of the selected row.
                string nameToDelete = dataGridView2.Rows[rowIndex].Cells["name"].Value.ToString();

                // Delete the selected row from the DataGridView.
                dataGridView2.Rows.RemoveAt(rowIndex);

                try
                {
                    using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                    {
                        db.Open();

                        // Create the SQL DELETE statement to delete the record with the selected name.
                        var deleteSql = "DELETE FROM livestock WHERE name = @name;";

                        // Create a MySqlCommand to execute the DELETE statement.
                        var deleteCmd = new MySqlCommand(deleteSql, db);
                        deleteCmd.Parameters.AddWithValue("@name", nameToDelete);

                        // Execute the SQL DELETE statement.
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Display a success message.
                            MessageBox.Show("Record deleted successfully!");
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
            


            // Check if there is a selected row in the DataGridView.
            if (dataGridView3.SelectedRows.Count > 0)
            {
                // Get the selected row index.
                int rowIndex = dataGridView3.CurrentCell.RowIndex;

                // Get the value from the "name" column of the selected row.
                string nameToDelete = dataGridView3.Rows[rowIndex].Cells["name"].Value.ToString();

                // Delete the selected row from the DataGridView.
                dataGridView3.Rows.RemoveAt(rowIndex);

                try
                {
                    using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                    {
                        db.Open();

                        // Create the SQL DELETE statement to delete the record with the selected name.
                        var deleteSql = "DELETE FROM fruits WHERE name = @name;";

                        // Create a MySqlCommand to execute the DELETE statement.
                        var deleteCmd = new MySqlCommand(deleteSql, db);
                        deleteCmd.Parameters.AddWithValue("@name", nameToDelete);

                        // Execute the SQL DELETE statement.
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Display a success message.
                            MessageBox.Show("Record deleted successfully!");
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
           



            // Check if there is a selected row in the DataGridView.
            if (dataGridView4.SelectedRows.Count > 0)
            {
                // Get the selected row index.
                int rowIndex = dataGridView4.CurrentCell.RowIndex;

                // Get the value from the "name" column of the selected row.
                string nameToDelete = dataGridView4.Rows[rowIndex].Cells["name"].Value.ToString();

                // Delete the selected row from the DataGridView.
                dataGridView4.Rows.RemoveAt(rowIndex);

                try
                {
                    using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                    {
                        db.Open();

                        // Create the SQL DELETE statement to delete the record with the selected name.
                        var deleteSql = "DELETE FROM milk WHERE name = @name;";

                        // Create a MySqlCommand to execute the DELETE statement.
                        var deleteCmd = new MySqlCommand(deleteSql, db);
                        deleteCmd.Parameters.AddWithValue("@name", nameToDelete);

                        // Execute the SQL DELETE statement.
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Display a success message.
                            MessageBox.Show("Record deleted successfully!");
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
