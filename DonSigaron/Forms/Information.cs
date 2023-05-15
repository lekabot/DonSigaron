using System;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class Information : Form
    {
        DataBase database = new DataBase();
        DBFunctions functions = new DBFunctions();
        public Information()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            RoundButton backToInfo = new RoundButton();
            backToInfo = Buttons.createButtonBack();
            backToInfo.Click += new System.EventHandler(this.back_Click);
            this.Controls.Add(backToInfo);

            orders.DataSource = functions.sqlSelect("SELECT * FROM orders");
            products.DataSource = functions.sqlSelect("SELECT * FROM products");
            manufacturer.DataSource = functions.sqlSelect("SELECT * FROM manufacturers");
            categories.DataSource = functions.sqlSelect("SELECT * FROM Categories");
        }

        private void back_Click(object sender, EventArgs e)
        {
            ActionsInTheApplication actionsInTheApplication = new ActionsInTheApplication();
            this.Hide();
            actionsInTheApplication.Show();
        }
    }
}
