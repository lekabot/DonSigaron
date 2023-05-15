using System;
using System.Data;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class History : Form
    {
        DBFunctions functions = new DBFunctions();

        public History()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void History_Load(object sender, EventArgs e)
        {
            DataTable userOrders = new DataTable();
            userOrders = functions.sqlSelect($"SELECT orders.id FROM orders INNER JOIN customers ON " +
                $"customers.id =  orders.customer_id WHERE username = '{VariableStorage.userName}'");
            int convertedOrders = Convert.ToInt32(userOrders.Rows[0][0]);

            dataCart.DataSource = functions.sqlSelect($"SELECT [products].[name], order_item.quantity, products.price FROM " +
                $"order_item INNER JOIN products ON order_item.product_id = products.product_id WHERE " +
                $"order_item.order_id = {convertedOrders} AND purchased = 1");

            RoundButton backToCatalog = new RoundButton();
            backToCatalog = Buttons.createButtonBack();
            backToCatalog.Click += new System.EventHandler(this.backToCart);
            this.Controls.Add(backToCatalog);
        }
        private void backToCart(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }
    }
}
