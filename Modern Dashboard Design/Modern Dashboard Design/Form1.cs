using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Modern_Dashboard_Design.Resources;

namespace Modern_Dashboard_Design
{
    public partial class Form1 : Form
    {
       
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
         int nHeightEllipse

      );

        public Form1(string username)
        {

            
            InitializeComponent();
            label1.Text = "Welcome, " + username;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
           

            Form5 form5 = new Form5();
            form5.TopLevel = false;
            form5.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
            form5.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(form5);
            form5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            // Close any existing child forms in panel3
            foreach (Control control in panel3.Controls)
            {
                if (control is Form)
                {
                    control.Dispose();
                }
            }

            // Close any existing child forms in panel3
            foreach (Control control in panel3.Controls)
            {
                if (control is Form)
                {
                    control.Dispose();
                }
            }

            // Highlight the selected button and adjust panel appearance
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            // Create and display Form5 within panel3
            Form5 form5 = new Form5();
            form5.TopLevel = false;
            form5.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
            form5.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(form5);
            form5.Show();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel3.Controls)
            {
                if (control is Form)
                {
                    control.Dispose();
                }
            }

            // Highlight the selected button and adjust panel appearance
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            // Create and display Form2 within panel3
            Form2 form2 = new Form2();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
            form2.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(form2);
            form2.Show();
        }

        private void BtnCalander_Click(object sender, EventArgs e)
        {

            // Close any existing child forms in panel3
            foreach (Control control in panel3.Controls)
            {
                if (control is Form)
                {
                    control.Dispose();
                }
            }

            // Highlight the selected button and adjust panel appearance
            pnlNav.Height = btnCalander.Height;
            pnlNav.Top = btnCalander.Top;
            btnCalander.BackColor = Color.FromArgb(46, 51, 73);

            // Create and display Form3 within panel3
            Form3 form3 = new Form3();
            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
            form3.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(form3);
            form3.Show();


        }

        private void BtnContactUs_Click(object sender, EventArgs e)
        {
            // Close any existing child forms in panel3
            foreach (Control control in panel3.Controls)
            {
                if (control is Form)
                {
                    control.Dispose();
                }
            }

            // Highlight the selected button and adjust panel appearance
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            // Create and display Form4 within panel3
            Form4 form4 = new Form4();
            form4.TopLevel = false;
            form4.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
            form4.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(form4);
            form4.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            // Open Form8
            Form8 form8 = new Form8();
            form8.Show();

            // Close the current form
            this.Close();

        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalander_Leave(object sender, EventArgs e)
        {
            btnCalander.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close any existing child forms in panel3
            foreach (Control control in panel3.Controls)
            {
                if (control is Form)
                {
                    control.Dispose();
                }
            }

            // Highlight the selected button and adjust panel appearance
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            // Create and display Form4 within panel3
            Form6 form6 = new Form6();
            form6.TopLevel = false;
            form6.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
            form6.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(form6);
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in panel3.Controls)
                {
                    if (control is Form)
                    {
                        control.Dispose();
                    }
                }

                pnlNav.Height = btnCalander.Height;
                pnlNav.Top = btnCalander.Top;
                btnCalander.BackColor = Color.FromArgb(46, 51, 73);

              EmpAdd addEmpForm = new EmpAdd(); // Instantiate AddEmp instead of Form3
                addEmpForm.TopLevel = false;
                addEmpForm.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
                addEmpForm.Dock = DockStyle.Fill; // Optional: Fill the panel
                panel3.Controls.Add(addEmpForm);
                addEmpForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Dispose of any existing forms within panel3
                foreach (Control control in panel3.Controls)
                {
                    if (control is Form)
                    {
                        control.Dispose();
                    }
                }

                // Set the appearance of the button
                pnlNav.Height = btnCalander.Height;
                pnlNav.Top = btnCalander.Top;
                btnCalander.BackColor = Color.FromArgb(46, 51, 73);

                // Instantiate Form9 and add it to panel3
                Form9 form9 = new Form9();
                form9.TopLevel = false;
                form9.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
                form9.Dock = DockStyle.Fill; // Optional: Fill the panel
                panel3.Controls.Add(form9);
                form9.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Dispose of any existing forms within panel3
                foreach (Control control in panel3.Controls)
                {
                    if (control is Form)
                    {
                        control.Dispose();
                    }
                }

                // Set the appearance of the button
                pnlNav.Height = btnCalander.Height;
                pnlNav.Top = btnCalander.Top;
                btnCalander.BackColor = Color.FromArgb(46, 51, 73);

                // Instantiate the new form (replace Form9 with your desired form class)
                order newForm = new order(); // Replace YourFormClass with the actual class of the form you want to open
                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None; // Optional: Remove border
                newForm.Dock = DockStyle.Fill; // Optional: Fill the panel
                panel3.Controls.Add(newForm);
                newForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}
