using Modern_Dashboard_Design.Resources;
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
    public partial class EmployeeDashboar : Form
    {
        public EmployeeDashboar(string username)
        {

            InitializeComponent();
            label1.Text = "Welcome, " + username;

            lordData();




        }

        public void lordData()
        {
            // Initialize a connection to the MySQL database.
            using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
            {
                try
                {
                    db.Open();

                    // Create and execute a SQL query to retrieve the veg table names.
                    var sql = "SELECT name FROM veg;";
                    var cmd = new MySqlCommand(sql, db);
                    var reader = cmd.ExecuteReader();

                    // Clear the ComboBox in case it already has items.
                    comboBox1.Items.Clear();

                    // Iterate through the result set and add names to the ComboBox.
                    while (reader.Read())
                    {
                        string vegName = reader["name"].ToString();
                        comboBox1.Items.Add(vegName);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database operations.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            // Initialize a connection to the MySQL database.
            using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
            {
                try
                {
                    db.Open();

                    // Create and execute a SQL query to retrieve the veg table names.
                    var sql = "SELECT name FROM fruits;";
                    var cmd = new MySqlCommand(sql, db);
                    var reader = cmd.ExecuteReader();

                    // Clear the ComboBox in case it already has items.
                    comboBox3.Items.Clear();

                    // Iterate through the result set and add names to the ComboBox.
                    while (reader.Read())
                    {
                        string vegName = reader["name"].ToString();
                        comboBox3.Items.Add(vegName);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database operations.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            // Initialize a connection to the MySQL database.
            using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
            {
                try
                {
                    db.Open();

                    // Create and execute a SQL query to retrieve the veg table names.
                    var sql = "SELECT name FROM milk;";
                    var cmd = new MySqlCommand(sql, db);
                    var reader = cmd.ExecuteReader();

                    // Clear the ComboBox in case it already has items.
                    comboBox4.Items.Clear();

                    // Iterate through the result set and add names to the ComboBox.
                    while (reader.Read())
                    {
                        string vegName = reader["name"].ToString();
                        comboBox4.Items.Add(vegName);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database operations.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            // Initialize a connection to the MySQL database.
            using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
            {
                try
                {
                    db.Open();

                    // Create and execute a SQL query to retrieve the veg table names.
                    var sql = "SELECT name FROM livestock;";
                    var cmd = new MySqlCommand(sql, db);
                    var reader = cmd.ExecuteReader();

                    // Clear the ComboBox in case it already has items.
                    comboBox2.Items.Clear();

                    // Iterate through the result set and add names to the ComboBox.
                    while (reader.Read())
                    {
                        string vegName = reader["name"].ToString();
                        comboBox2.Items.Add(vegName);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database operations.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {  // Get the selected item from comboBox1
            string selectedVegName = comboBox1.SelectedItem as string;

            // Check if an item is selected
            if (!string.IsNullOrWhiteSpace(selectedVegName))
            {
                // Get the quantity as a string from textBox1
                string qty = textBox1.Text;

                // Get the customer name from textBox5
                string customerName = textBox5.Text;

                // Check if a customer name is entered
                if (!string.IsNullOrWhiteSpace(customerName))
                {
                    // Check if a quantity is entered
                    if (!string.IsNullOrWhiteSpace(qty))
                    {
                        // Save the data to the database
                        using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                        {
                            try
                            {
                                db.Open();

                                // Create the SQL INSERT statement with columns in the desired order
                                var sql = "INSERT INTO items (cname, orderitem, qty) VALUES (@cname, @orderitem, @qty);";

                                // Bind the parameters in the desired order
                                var cmd = new MySqlCommand(sql, db);
                                cmd.Parameters.AddWithValue("@cname", customerName);
                                cmd.Parameters.AddWithValue("@orderitem", selectedVegName);
                                cmd.Parameters.AddWithValue("@qty", qty);

                                // Execute the SQL statement.
                                cmd.ExecuteNonQuery();

                                // Display a success message.
                                string message = "Data saved successfully!";
                                // Display the message in a message box.
                                MessageBox.Show(message);

                                // Clear the input fields
                                comboBox1.SelectedIndex = -1; // Clear the selection
                                textBox1.Text = "";
                                textBox5.Text = "";
                            }
                            catch (Exception ex)
                            {
                                // Handle any exceptions that may occur during database operations.
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a customer name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a vegetable from the ComboBox.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Get the selected item from comboBox1
            string selectedVegName = comboBox2.SelectedItem as string;

            // Check if an item is selected
            if (!string.IsNullOrWhiteSpace(selectedVegName))
            {
                // Get the quantity as a string from textBox1
                string qty = textBox2.Text;

                // Get the customer name from textBox5
                string customerName = textBox5.Text;

                // Check if a customer name is entered
                if (!string.IsNullOrWhiteSpace(customerName))
                {
                    // Check if a quantity is entered
                    if (!string.IsNullOrWhiteSpace(qty))
                    {
                        // Save the data to the database
                        using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                        {
                            try
                            {
                                db.Open();

                                // Create the SQL INSERT statement with columns in the desired order
                                var sql = "INSERT INTO items (cname, orderitem, qty) VALUES (@cname, @orderitem, @qty);";

                                // Bind the parameters in the desired order
                                var cmd = new MySqlCommand(sql, db);
                                cmd.Parameters.AddWithValue("@cname", customerName);
                                cmd.Parameters.AddWithValue("@orderitem", selectedVegName);
                                cmd.Parameters.AddWithValue("@qty", qty);

                                // Execute the SQL statement.
                                cmd.ExecuteNonQuery();

                                // Display a success message.
                                string message = "Data saved successfully!";
                                // Display the message in a message box.
                                MessageBox.Show(message);

                                // Clear the input fields
                                comboBox1.SelectedIndex = -1; // Clear the selection
                                textBox1.Text = "";
                                textBox5.Text = "";
                            }
                            catch (Exception ex)
                            {
                                // Handle any exceptions that may occur during database operations.
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a customer name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a vegetable from the ComboBox.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the selected item from comboBox1
            string selectedVegName = comboBox3.SelectedItem as string;

            // Check if an item is selected
            if (!string.IsNullOrWhiteSpace(selectedVegName))
            {
                // Get the quantity as a string from textBox1
                string qty = textBox3.Text;

                // Get the customer name from textBox5
                string customerName = textBox5.Text;

                // Check if a customer name is entered
                if (!string.IsNullOrWhiteSpace(customerName))
                {
                    // Check if a quantity is entered
                    if (!string.IsNullOrWhiteSpace(qty))
                    {
                        // Save the data to the database
                        using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                        {
                            try
                            {
                                db.Open();

                                // Create the SQL INSERT statement with columns in the desired order
                                var sql = "INSERT INTO items (cname, orderitem, qty) VALUES (@cname, @orderitem, @qty);";

                                // Bind the parameters in the desired order
                                var cmd = new MySqlCommand(sql, db);
                                cmd.Parameters.AddWithValue("@cname", customerName);
                                cmd.Parameters.AddWithValue("@orderitem", selectedVegName);
                                cmd.Parameters.AddWithValue("@qty", qty);

                                // Execute the SQL statement.
                                cmd.ExecuteNonQuery();

                                // Display a success message.
                                string message = "Data saved successfully!";
                                // Display the message in a message box.
                                MessageBox.Show(message);

                                // Clear the input fields
                                comboBox1.SelectedIndex = -1; // Clear the selection
                                textBox1.Text = "";
                                textBox5.Text = "";
                            }
                            catch (Exception ex)
                            {
                                // Handle any exceptions that may occur during database operations.
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a customer name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a vegetable from the ComboBox.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get the selected item from comboBox1
            string selectedVegName = comboBox4.SelectedItem as string;

            // Check if an item is selected
            if (!string.IsNullOrWhiteSpace(selectedVegName))
            {
                // Get the quantity as a string from textBox1
                string qty = textBox4.Text;

                // Get the customer name from textBox5
                string customerName = textBox5.Text;

                // Check if a customer name is entered
                if (!string.IsNullOrWhiteSpace(customerName))
                {
                    // Check if a quantity is entered
                    if (!string.IsNullOrWhiteSpace(qty))
                    {
                        // Save the data to the database
                        using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                        {
                            try
                            {
                                db.Open();

                                // Create the SQL INSERT statement with columns in the desired order
                                var sql = "INSERT INTO items (cname, orderitem, qty) VALUES (@cname, @orderitem, @qty);";

                                // Bind the parameters in the desired order
                                var cmd = new MySqlCommand(sql, db);
                                cmd.Parameters.AddWithValue("@cname", customerName);
                                cmd.Parameters.AddWithValue("@orderitem", selectedVegName);
                                cmd.Parameters.AddWithValue("@qty", qty);

                                // Execute the SQL statement.
                                cmd.ExecuteNonQuery();

                                // Display a success message.
                                string message = "Data saved successfully!";
                                // Display the message in a message box.
                                MessageBox.Show(message);

                                // Clear the input fields
                                comboBox1.SelectedIndex = -1; // Clear the selection
                                textBox1.Text = "";
                                textBox5.Text = "";
                            }
                            catch (Exception ex)
                            {
                                // Handle any exceptions that may occur during database operations.
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a customer name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a vegetable from the ComboBox.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

          

            // Open Form8
            Form8 form8 = new Form8();
            form8.Show();

            // Close the current form
            this.Close();
        }
    }
}
    