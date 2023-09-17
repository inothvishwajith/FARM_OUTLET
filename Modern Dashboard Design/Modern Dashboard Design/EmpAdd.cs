using MySqlConnector;
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

namespace Modern_Dashboard_Design
{
    public partial class EmpAdd : Form
    {
        public EmpAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Database connection string
                string connectionString = "server=localhost;database=farm;username=root;password=";

                using (var db = new MySqlConnection(connectionString))
                {
                    db.Open();

                    // Create a SQL command
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Users (name, email, username, Pw, type) VALUES (@Name, @Email, @Username, @Password, @UserType)", db))
                    {
                        // Set parameters
                        cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Username", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox4.Text);

                        // Determine the selected user type
                        string userType = radioButton1.Checked ? "Admin" : "Emp";
                        cmd.Parameters.AddWithValue("@UserType", userType);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Data successfully inserted
                            MessageBox.Show("User data saved successfully!");
                        }
                        else
                        {
                            // Something went wrong
                            MessageBox.Show("Error saving user data.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear text fields
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            // Clear radio buttons
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}