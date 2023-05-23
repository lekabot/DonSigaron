using System;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class StuffLogin : Form
    {
        DataBase database = new DataBase();
        DBFunctions functions = new DBFunctions();
        public StuffLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            text_password.PasswordChar = '*';
        }
        private void sign_in_Load(object sender, EventArgs e)
        {
            text_password.MaxLength = 50;
            text_name.MaxLength = 50;
            
        }

        private void roundButton1_Click_1(object sender, EventArgs e)
        {
            var login = text_name.Text;
            var password = text_password.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("You have not entered the login of password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (functions.sqlSelect($"SELECT username, [password] FROM employees WHERE username = '{login}' and [password] = '{password}'").Rows.Count > 0)
                {
                    MessageBox.Show("You have successfully logged in!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChoseTabls choseTabls = new ChoseTabls();
                    choseTabls.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("There is no such account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
