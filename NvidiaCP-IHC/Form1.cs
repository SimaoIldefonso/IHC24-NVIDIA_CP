using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management;

namespace NvidiaCP_IHC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 28, 28);

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string usernameWithoutDomain = userName.Split('\\')[1];

            // retrieve pc specs like cpu and gpu
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject share in searcher.Get())
            {
                specs_label.Text = "CPU: " + share["Name"].ToString();
            }

            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject share in searcher2.Get())
            {
                specs_label.Text += "\nGPU: " + share["Name"].ToString();
            }


            label9.Text = "Welcome\n" + usernameWithoutDomain;
            label9.ForeColor = Color.FromArgb(235, 235, 235);
            label9.TextAlign = ContentAlignment.MiddleCenter;

            label10.ForeColor = Color.FromArgb(235, 235, 235);

            label11.BackColor = Color.FromArgb(94, 140, 12);
            label12.BackColor = Color.FromArgb(94, 140, 12);
            label13.BackColor = Color.FromArgb(94, 140, 12);
            label14.BackColor = Color.FromArgb(94, 140, 12);

            comboBox1.SelectedIndex = 1;
            // mudar cor da string
            comboBox1.BackColor = Color.FromArgb(45, 45, 45);
            comboBox1.ForeColor = Color.FromArgb(235, 235, 235);

            label19.ForeColor = Color.FromArgb(235, 235, 235);
            label20.ForeColor = Color.FromArgb(235, 235, 235);
            label21.ForeColor = Color.FromArgb(235, 235, 235);

            specs_label.ForeColor = Color.FromArgb(235, 235, 235);

            label5.BackColor = Color.FromArgb(118, 185, 0);
            label5.Text = "";

            label6.BackColor = Color.FromArgb(28, 28, 28);
            label6.Text = "";

            label7.BackColor = Color.FromArgb(28, 28, 28);
            label7.Text = "";

            label8.BackColor = Color.FromArgb(28, 28, 28);
            label8.Text = "";

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;

            tableLayoutPanel1.BackColor = Color.FromArgb(28, 28, 28);
            tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;


            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text = "";
                tab.BackColor = Color.FromArgb(28, 28, 28);
                tab.BorderStyle = BorderStyle.None;
            }
        }

        // COLORING TABS //
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.White)) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        private void tableLayoutPanel2_CellPaintYES(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 0 && e.Row == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(118, 185, 0))) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        private void tableLayoutPanel2_CellPaintNO(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 0 && e.Row == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(28, 28, 28))) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        private void tableLayoutPanel3_CellPaintYES(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 0 && e.Row == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(118, 185, 0))) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        private void tableLayoutPanel3_CellPaintNO(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 0 && e.Row == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(28, 28, 28))) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        private void tableLayoutPanel4_CellPaintYES(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 0 && e.Row == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(118, 185, 0))) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        private void tableLayoutPanel4_CellPaintNO(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 0 && e.Row == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(28, 28, 28))) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        private void tableLayoutPanel5_CellPaintYES(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 0 && e.Row == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(118, 185, 0))) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        private void tableLayoutPanel5_CellPaintNO(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Check if the current cell belongs to the middle column
            if (e.Column == 0 && e.Row == 1) // Assuming 0-based index
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(28, 28, 28))) // Customize the color
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds); // Paint the cell background
                }
            }
        }

        // COLORING TABS //

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(home_tab);

            label5.BackColor = Color.FromArgb(118, 185, 0);
            label5.Text = "";

            label6.BackColor = Color.FromArgb(28, 28, 28);
            label6.Text = "";

            label7.BackColor = Color.FromArgb(28, 28, 28);
            label7.Text = "";

            label8.BackColor = Color.FromArgb(28, 28, 28);
            label8.Text = "";

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(display_tab);

            label5.BackColor = Color.FromArgb(28, 28, 28);
            label5.Text = "";

            label6.BackColor = Color.FromArgb(118, 185, 0);
            label6.Text = "";

            label7.BackColor = Color.FromArgb(28, 28, 28);
            label7.Text = "";

            label8.BackColor = Color.FromArgb(28, 28, 28);
            label8.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(graph_tab);

            label5.BackColor = Color.FromArgb(28, 28, 28);
            label5.Text = "";

            label6.BackColor = Color.FromArgb(28, 28, 28);
            label6.Text = "";

            label7.BackColor = Color.FromArgb(118, 185, 0);
            label7.Text = "";

            label8.BackColor = Color.FromArgb(28, 28, 28);
            label8.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(settings_tab);

            label5.BackColor = Color.FromArgb(28, 28, 28);
            label5.Text = "";

            label6.BackColor = Color.FromArgb(28, 28, 28);
            label6.Text = "";

            label7.BackColor = Color.FromArgb(28, 28, 28);
            label7.Text = "";

            label8.BackColor = Color.FromArgb(118, 185, 0); 
            label8.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            label11.BackColor = Color.FromArgb(94, 140, 12);
            label12.BackColor = Color.FromArgb(94, 140, 12);
            label13.BackColor = Color.FromArgb(94, 140, 12);
            label14.BackColor = Color.FromArgb(94, 140, 12);

            label15.BackColor = Color.FromArgb(28, 28, 28);
            label16.BackColor = Color.FromArgb(28, 28, 28);
            label17.BackColor = Color.FromArgb(28, 28, 28);
            label18.BackColor = Color.FromArgb(28, 28, 28);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label11.BackColor = Color.FromArgb(28, 28, 28);
            label12.BackColor = Color.FromArgb(28, 28, 28);
            label13.BackColor = Color.FromArgb(28, 28, 28);
            label14.BackColor = Color.FromArgb(28, 28, 28);

            label15.BackColor = Color.FromArgb(94, 140, 12);
            label16.BackColor = Color.FromArgb(94, 140, 12);
            label17.BackColor = Color.FromArgb(94, 140, 12);
            label18.BackColor = Color.FromArgb(94, 140, 12);
        }
    }
}
