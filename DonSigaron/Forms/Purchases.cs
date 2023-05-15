using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class Purchases : Form
    {
        DBFunctions functions = new DBFunctions();

        public Purchases()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
            createButtons();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            DataTable tableTakingUserID = new DataTable();
            tableTakingUserID = functions.sqlSelect($"SELECT id FROM customers WHERE username = '{VariableStorage.userName}'");
            int userID = Convert.ToInt32(tableTakingUserID.Rows[0][0]);

            DataTable deliveryPoints = new DataTable();
            deliveryPoints = functions.sqlSelect($"SELECT title FROM addresses JOIN customers ON addresses.customer_id = customers.id WHERE customer_id = {userID}");
            obtain.Items.Clear();
            foreach (DataRow row in deliveryPoints.Rows)
            {
                string title = row["title"].ToString();
                obtain.Items.Add(title);
            }

            DataTable payMethod = new DataTable();
            payMethod = functions.sqlSelect($"SELECT number FROM cards JOIN customers ON cards.[user_id] = customers.id WHERE customers.id = {userID}");
            payment.Items.Clear();
            foreach (DataRow row in payMethod.Rows)
            {
                string number = row["number"].ToString();
                payment.Items.Add(number);
            }
        }

        private void goToCart1_Click(object sender, System.EventArgs e)
        {
            Cart cart = new Cart();
            this.Hide();
            cart.ShowDialog();
        }
        private void createButtons()
        {
            RoundButton backToInfo = new RoundButton();
            backToInfo = Buttons.createButtonBack();
            backToInfo.Click += new System.EventHandler(this.goToCart1_Click);
            this.Controls.Add(backToInfo);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if ((payment.SelectedItem != null) && (obtain.SelectedItem != null))
            {
                DataTable userOrders = new DataTable();
                userOrders = functions.sqlSelect($"SELECT orders.id FROM orders INNER JOIN customers ON " +
                    $"customers.id =  orders.customer_id WHERE username = '{VariableStorage.userName}'");
                int convertedOrders = Convert.ToInt32(userOrders.Rows[0][0]);

                DataTable gettingProductID = new DataTable();
                gettingProductID = functions.sqlSelect($"SELECT [products].[product_id], order_item.quantity, [products].stock FROM " +
                    $"order_item INNER JOIN products ON order_item.product_id = products.product_id WHERE " +
                    $"order_item.order_id = {convertedOrders} AND purchased = 0");


                for (int i = 0; i < gettingProductID.Rows.Count; i++)
                {
                    int productID = Convert.ToInt32(gettingProductID.Rows[i][0]);
                    int quantity = Convert.ToInt32(gettingProductID.Rows[i][1]);
                    int stockProduct = Convert.ToInt32(gettingProductID.Rows[i][2]);
                    int updateStock = stockProduct - quantity;

                    SqlCommand buyingProduct = new SqlCommand();
                    buyingProduct = functions.sqlInsert($"UPDATE [dbo].[order_item] SET purchased = 1 WHERE product_id = {productID}");
                    buyingProduct.ExecuteNonQuery();
                    SqlCommand removeQuantityDB = new SqlCommand();
                    removeQuantityDB = functions.sqlInsert($"UPDATE [dbo].[products] SET stock = {updateStock} WHERE product_id = {productID}");
                    removeQuantityDB.ExecuteNonQuery();

                }

                MessageBox.Show("Expect your delivery", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
            else
            {
                MessageBox.Show("You did not specify the address or payment", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addPayment_Click(object sender, EventArgs e)
        {
            //Здесь переход на новую форму, где можно будет задать свой адресс
            Address address = new Address();
            address.Show();
            this.Hide();
        }

        private void addObtain_Click(object sender, EventArgs e)
        {
            //Здесь переход на новую форму, где можно указать карту для оплаты и эти данные апдейтнуть в таблицу [dbo].[cards]
            AddPaymethod addPaymethod = new AddPaymethod();
            addPaymethod.Show();
            this.Hide();
        }

        
    }
}
