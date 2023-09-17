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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            lordData();
        }
        public void lordData()
        {
            try
            {
                using (var db = new MySqlConnection("server=localhost;database=farm;username=root;password="))
                {
                    db.Open();

                    // Create a SQL command to fetch data from the database
                    string sql = "SELECT cname, orderitem, qty FROM items;";
                    var cmd = new MySqlCommand(sql, db);

                    // Create a DataTable to hold the results
                    DataTable dataTable = new DataTable();

                    // Load data from the database into the DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
