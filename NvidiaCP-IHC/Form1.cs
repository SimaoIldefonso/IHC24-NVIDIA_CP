﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
//using System.Drawing.Drawing2D;

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
            label22.ForeColor = Color.FromArgb(235, 235, 235);
            label23.ForeColor = Color.FromArgb(235, 235, 235);
            label24.ForeColor = Color.FromArgb(235, 235, 235);
            label25.ForeColor = Color.FromArgb(235, 235, 235);

            label26.ForeColor = Color.FromArgb(235, 235, 235);
            label27.ForeColor = Color.FromArgb(235, 235, 235);
            label28.ForeColor = Color.FromArgb(235, 235, 235);
            label29.ForeColor = Color.FromArgb(235, 235, 235);
            label30.ForeColor = Color.FromArgb(235, 235, 235);
            label31.ForeColor = Color.FromArgb(235, 235, 235);
            label32.ForeColor = Color.FromArgb(235, 235, 235);
            label33.ForeColor = Color.FromArgb(235, 235, 235);
            label34.ForeColor = Color.FromArgb(235, 235, 235);
            label35.ForeColor = Color.FromArgb(235, 235, 235);
            label36.ForeColor = Color.FromArgb(235, 235, 235);
            label37.ForeColor = Color.FromArgb(235, 235, 235);
            label38.ForeColor = Color.FromArgb(235, 235, 235);
            label39.ForeColor = Color.FromArgb(235, 235, 235);
            label40.ForeColor = Color.FromArgb(235, 235, 235);
            label41.ForeColor = Color.FromArgb(235, 235, 235);
            label42.ForeColor = Color.FromArgb(235, 235, 235);

            label11.BackColor = Color.FromArgb(94, 140, 12);
            label12.BackColor = Color.FromArgb(94, 140, 12);
            label13.BackColor = Color.FromArgb(94, 140, 12);
            label14.BackColor = Color.FromArgb(94, 140, 12);

            comboBox1.SelectedIndex = 1;
            comboBox1.BackColor = Color.FromArgb(45, 45, 45);
            comboBox1.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox2.SelectedIndex = 0;
            comboBox2.BackColor = Color.FromArgb(45, 45, 45);
            comboBox2.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox3.SelectedIndex = 0;
            comboBox3.BackColor = Color.FromArgb(45, 45, 45);
            comboBox3.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox4.Items.Add("Auto-Select");
            comboBox4.SelectedIndex = 0;
            comboBox4.BackColor = Color.FromArgb(45, 45, 45);
            comboBox4.ForeColor = Color.FromArgb(235, 235, 235);

            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject share in searcher2.Get())
            {
                comboBox4.Items.Add(share["Name"].ToString());
            }

            comboBox5.SelectedIndex = 0;
            comboBox5.BackColor = Color.FromArgb(45, 45, 45);
            comboBox5.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox6.SelectedIndex = 0;
            comboBox6.BackColor = Color.FromArgb(45, 45, 45);
            comboBox6.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox7.SelectedIndex = 0;
            comboBox7.BackColor = Color.FromArgb(45, 45, 45);
            comboBox7.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox8.SelectedIndex = 1;
            comboBox8.BackColor = Color.FromArgb(45, 45, 45);
            comboBox8.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox9.SelectedIndex = 0;
            comboBox9.BackColor = Color.FromArgb(45, 45, 45);
            comboBox9.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox10.SelectedIndex = 6;
            comboBox10.BackColor = Color.FromArgb(45, 45, 45);
            comboBox10.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox11.SelectedIndex = 2;
            comboBox11.BackColor = Color.FromArgb(45, 45, 45);
            comboBox11.ForeColor = Color.FromArgb(235, 235, 235);

            // Program Selection
            comboBox12.SelectedIndex = 0;
            comboBox12.BackColor = Color.FromArgb(45, 45, 45);
            comboBox12.ForeColor = Color.FromArgb(235, 235, 235);
            //

            comboBox13.SelectedIndex = 0;
            comboBox13.BackColor = Color.FromArgb(45, 45, 45);
            comboBox13.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox14.SelectedIndex = 0;
            comboBox14.BackColor = Color.FromArgb(45, 45, 45);
            comboBox14.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox15.SelectedIndex = 0;
            comboBox15.BackColor = Color.FromArgb(45, 45, 45);
            comboBox15.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox16.SelectedIndex = 1;
            comboBox16.BackColor = Color.FromArgb(45, 45, 45);
            comboBox16.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox17.SelectedIndex = 0;
            comboBox17.BackColor = Color.FromArgb(45, 45, 45);
            comboBox17.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox18.SelectedIndex = 6;
            comboBox18.BackColor = Color.FromArgb(45, 45, 45);
            comboBox18.ForeColor = Color.FromArgb(235, 235, 235);

            comboBox19.SelectedIndex = 2;
            comboBox19.BackColor = Color.FromArgb(45, 45, 45);
            comboBox19.ForeColor = Color.FromArgb(235, 235, 235);

            label19.ForeColor = Color.FromArgb(235, 235, 235);
            label20.ForeColor = Color.FromArgb(235, 235, 235);
            label21.ForeColor = Color.FromArgb(235, 235, 235);

            tabPage1.BackColor = Color.FromArgb(28, 28, 28);
            tabPage2.BackColor = Color.FromArgb(28, 28, 28);

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
            //apply está em elipse
            //GraphicsPath gp = new GraphicsPath();
            //gp.AddEllipse(new Rectangle(0, 0, button4.Width, button4.Height));
            //button4.Region = new Region(gp);

            /////////////////////////////////////////


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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore default values?", "Apply Settings", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                comboBox1.SelectedIndex = 1;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
            }
            else if (dialogResult == DialogResult.No)
            {
                // do nothing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to apply settings?", "Apply Settings", MessageBoxButtons.YesNo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore default values?", "Restore default values", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                comboBox4.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;
                comboBox6.SelectedIndex = 0;
                comboBox7.SelectedIndex = 0;
                comboBox8.SelectedIndex = 1;
                comboBox9.SelectedIndex = 0;
                comboBox10.SelectedIndex = 6;
                comboBox11.SelectedIndex = 2;
            }
            else if (dialogResult == DialogResult.No)
            {
                // do nothing
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to apply settings?", "Apply Settings", MessageBoxButtons.YesNo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex != 0)
            {
                comboBox12.Items.RemoveAt(comboBox12.SelectedIndex);
                comboBox12.SelectedIndex = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Programs|*.exe|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                string programName = System.IO.Path.GetFileNameWithoutExtension(selectedFilePath);
                comboBox12.Items.Add(programName);
                comboBox12.SelectedIndex = comboBox12.Items.Count - 1;
            }
        }

        private void label42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(graph_tab);
            comboBox8.Select();
        }
    }
}
