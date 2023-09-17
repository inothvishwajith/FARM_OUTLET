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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // Get the data from the textboxes.
            string name = textBox1.Text;
            string lml = textBox2.Text;
            double qty = double.Parse(textBox3.Text);

            // Save the data to the database.
            using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
            {
                db.Open();

                // Create the SQL INSERT statement.
                var sql = $"INSERT INTO  livestock (name, lml, qty) VALUES (@name, '{lml}', {qty});";

                // Bind the parameters.
                var cmd = new MySqlCommand(sql, db);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lml", lml);
                cmd.Parameters.AddWithValue("@qty", qty);

                // Execute the SQL statement.
                cmd.ExecuteNonQuery();
                // Display a success message.
                string message = "Data saved successfully!";
                // Display the message in a message box.
                MessageBox.Show(message);

                // Clear the textbox data.
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
