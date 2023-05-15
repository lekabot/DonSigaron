using System;
using System.Data;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class Cart : Form
    {
        Buttons button = new Buttons();
        DBFunctions functions = new DBFunctions();

        public Cart()
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Cart_Load(object sender, EventArgs e)
        {

            RoundButton backToCatalog = new RoundButton();
            backToCatalog = Buttons.createButtonBack();
            backToCatalog.Click += new System.EventHandler(this.backToCatalog_Click);
            this.Controls.Add(backToCatalog);

            DataTable userOrders = new DataTable();
            userOrders = functions.sqlSelect($"SELECT orders.id FROM orders INNER JOIN customers ON " +
                $"customers.id =  orders.customer_id WHERE username = '{VariableStorage.userName}'");
            int convertedOrders = Convert.ToInt32(userOrders.Rows[0][0]);

            dataCart.DataSource = functions.sqlSelect($"SELECT [products].[name], order_item.quantity, products.price FROM " +
                $"order_item INNER JOIN products ON order_item.product_id = products.product_id WHERE " +
                $"order_item.order_id = {convertedOrders} AND purchased = 0");

        }

        private void backToCatalog_Click(object sender, System.EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }

        private void design_Click(object sender, EventArgs e)
        {
            Purchases design = new Purchases();
            design.Show();
            this.Hide();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }
    }
}
