﻿using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class Registration : Form
    {
        DBFunctions functions = new DBFunctions();
        DataBase database = new DataBase();
        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_first_name.MaxLength = 50;
            textBox_last_name.MaxLength = 50;
            textBox_email.MaxLength = 50;
            textBox_password.MaxLength = 50;
            textBox_address.MaxLength = 50;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var first_name = textBox_first_name.Text;
            var last_name = textBox_last_name.Text;
            var email = textBox_email.Text;
            var phone_number = textBox_phone_number.Text;
            var username = textBox_username.Text;
            var password = textBox_password.Text;
            var address = textBox_address.Text;

            if (new[] { textBox_first_name.Text, textBox_last_name.Text, textBox_email.Text, textBox_phone_number.Text, textBox_username.Text, textBox_password.Text, textBox_address.Text }
                    .All(x => string.IsNullOrWhiteSpace(x)))
            {
                MessageBox.Show("You didn't specify a field", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (functions.CheckAccauntInExistDB(username, email) == true)
                {
                    MessageBox.Show("Such E-mail or Username is already registered", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    SqlCommand command = new SqlCommand();
                    command = functions.sqlInsert($"INSERT INTO customers (first_name, last_name, email, phone, username, [password]) VALUES ('{first_name}', '{last_name}', '{email}', '{phone_number}', '{username}', '{password}');");
                    if (command.ExecuteNonQuery() == 1)
                    {
                        VariableStorage.userName = username;
                        var a = functions.sqlSelect($"SELECT id FROM [dbo].[customers] WHERE username = '{username}'");
                        int b = Convert.ToInt32(a.Rows[0][0]);

                        functions.sqlInsert($"INSERT INTO [dbo].[addresses](title, customer_id) VALUES('{textBox_address.Text}', {b});").ExecuteNonQuery();
                    
                        var addressID = functions.sqlSelect($"SELECT id FROM [dbo].[addresses] WHERE title = '{address}'");
                        int addIdConvert = Convert.ToInt32(addressID.Rows[0][0]);

                        functions.sqlInsert($"UPDATE [dbo].[customers] SET address_id = {addIdConvert} WHERE id = {b};").ExecuteNonQuery();

                        MessageBox.Show("You have created an account", "Account added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActionsInTheApplication actionsInTheApplication = new ActionsInTheApplication();
                        actionsInTheApplication.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Something's wrong", "Account not created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
        }
        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authorization log = new Authorization();
            log.Show();
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
