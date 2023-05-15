using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class AddPaymethod : Form
    {
        DBFunctions functions = new DBFunctions();
        public AddPaymethod()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
            textBox_number.MaxLength = 16;
            textBox_date.MaxLength = 6;
            textBox_CVV.MaxLength = 3;
        }

        private void AddPaymethod_Load(object sender, EventArgs e)
        {
            RoundButton backToInfo = new RoundButton();
            backToInfo = Buttons.createButtonBack();
            backToInfo.Click += new System.EventHandler(this.backToActions_Click);
            this.Controls.Add(backToInfo);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            string number = textBox_number.Text;
            DateTime dateTime = DateTime.Parse(textBox_date.Text);
            
            string cvv = textBox_CVV.Text;
            
            if (dateTime < DateTime.Now)
            {
                MessageBox.Show("The card date is entered incorrectly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!string.IsNullOrWhiteSpace(number) && !string.IsNullOrWhiteSpace(textBox_date.Text) && !string.IsNullOrWhiteSpace(cvv))
            {
                DataTable tableTakingUserID = new DataTable();
                tableTakingUserID = functions.sqlSelect($"SELECT id FROM customers WHERE username = '{VariableStorage.userName}'");
                int userID = Convert.ToInt32(tableTakingUserID.Rows[0][0]);

                SqlCommand command = new SqlCommand();
                command = functions.sqlInsert($"INSERT INTO [dbo].[cards] VALUES('{number}', '{dateTime}', '{cvv}', '{userID}')");
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You have added an cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
