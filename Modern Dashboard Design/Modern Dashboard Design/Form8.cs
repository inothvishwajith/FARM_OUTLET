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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Modern_Dashboard_Design
{
    public partial class Form8 : Form
    {


        

        public Form8()
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

                    // Create a SQL command for user authentication
                    using (MySqlCommand cmd = new MySqlCommand("SELECT type FROM users WHERE username = @Username AND pw = @Password", db))
                    {
                        // Set parameters for username and password
                        cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                        // Execute the query
                        object userType = cmd.ExecuteScalar();

                        if (userType != null)
                        {
                            // User authentication succeeded
                            string userTypeStr = userType.ToString();

                            if (userTypeStr == "Admin")
                            {
                                // Redirect to the admin dashboard and pass the username
                                Form1 adminDashboard = new Form1(textBox1.Text); // Pass the username
                                adminDashboard.Show();
                                this.Hide();
                            }
                            else if (userTypeStr == "Emp")
                            {
                                // Redirect to the employee dashboard (you should have a form named EmployeeDashboard)
                                EmployeeDashboar employeeDashboard = new EmployeeDashboar(textBox1.Text);
                                employeeDashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid user type.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
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
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
