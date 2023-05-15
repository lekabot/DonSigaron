using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class Address : Form
    {
        DBFunctions functions = new DBFunctions();
        Buttons buttons = new Buttons();

        public Address()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }

        private void Address_Load(object sender, EventArgs e)
        {
            RoundButton backToInfo = new RoundButton();
            backToInfo = Buttons.createButtonBack();
            backToInfo.Click += new System.EventHandler(this.backToActions_Click);
            this.Controls.Add(backToInfo);

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            DataTable tableTakingUserID = new DataTable();
            tableTakingUserID = functions.sqlSelect($"SELECT id FROM customers WHERE username = '{VariableStorage.userName}'");
            int userID = Convert.ToInt32(tableTakingUserID.Rows[0][0]);
            

            if (!string.IsNullOrWhiteSpace(text_address.Text))
            {
                SqlCommand command = new SqlCommand();
                command = functions.sqlInsert($"INSERT INTO addresses VALUES('{text_address.Text}', {userID})");
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You have added an addres", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something wrond", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You didn't specify an addressee", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backToActions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchases purchase = new Purchases();
            purchase.Show();

        }
    }
}
