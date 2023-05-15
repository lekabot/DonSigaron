using System;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class MainForm : Form
    {
        DataBase database = new DataBase();
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void roundButton1_Click(object sender, EventArgs e)
        {
            Authorization sign = new Authorization();
            sign.Show();
            this.Hide();
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
            this.Hide();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            StuffLogin admin = new StuffLogin();
            admin.Show();
            this.Hide();
        }
    }
}
