using System;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class Authorization : Form
    {
        DBFunctions functions = new DBFunctions();
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void sign_in_Load(object sender, EventArgs e)
        {
            text_password.PasswordChar = '*';
            text_password.MaxLength = 50;
            text_name.MaxLength = 50;
        }
        private void roundButton1_Click(object sender, EventArgs e)
        {
            
            var login = text_name.Text;
            var password = text_password.Text;
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("You have not entered the login of password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (functions.sqlSelect($"select username, password from customers where username = '{login}' AND password = '{password}'").Rows.Count > 0)
                {
                    MessageBox.Show("You have successfully logged in!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VariableStorage.userName = login;
                    ActionsInTheApplication actionsInTheApplication = new ActionsInTheApplication();
                    actionsInTheApplication.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("There is no such account or password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
            this.Hide();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
