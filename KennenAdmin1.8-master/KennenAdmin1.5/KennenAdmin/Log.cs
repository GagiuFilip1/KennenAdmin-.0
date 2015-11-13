using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace KennenAdmin
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }
        string ConnectionString = ConfigurationManager.ConnectionStrings["KennenAdmin"].ToString();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 8000;
            timer1.Enabled = true;
            timer1.Start();
            butonu.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox3.Hide();
            butonu.FlatAppearance.BorderSize = 0;
            butonu.FlatAppearance.MouseOverBackColor = BackColor;
            butonu.FlatAppearance.MouseDownBackColor = BackColor;
            butonu.FlatAppearance.BorderColor = Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = String.Empty;
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }  

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void butonu_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox2.Hide();
        }

        private void butonu_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox3.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            butonu.PerformClick();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form D = new Dropbox();
            D.Show();
        }

    }
}
