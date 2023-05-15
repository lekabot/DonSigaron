using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class Catalog : Form
    {

        DBFunctions functions = new DBFunctions();
        Form dataForm = new Form();
        Buttons backButton= new Buttons();
        NumericUpDown numericUpDown = new NumericUpDown();
        //public static string tableName;
        public static int selectedValue = 1;


        public Catalog()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Catalog_Load_1(object sender, EventArgs e)
        {
            RoundButton backToInfo = new RoundButton();
            backToInfo = Buttons.createButtonBack();
            backToInfo.Click += new System.EventHandler(this.backToActions_Click);
            this.Controls.Add(backToInfo);

            RoundButton cart = new RoundButton();
            cart = Buttons.createButtonCart();
            cart.Click += new System.EventHandler(this.goToCart1_Click);
            this.Controls.Add(cart);

            List<string> tableNames = functions.GetNamesFromTable();
            RoundButton[] buttons = new RoundButton[tableNames.Count];

            for (int i = 0; i < tableNames.Count; i++)
            {
                RoundButton button = new RoundButton();
                button.Text = tableNames[i];
                button.Size = new Size(100, 50);
                button.Location = new Point(i * 110 + 10, 60);
                buttons[i] = button;
                buttons[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
                buttons[i].BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
                buttons[i].ButtonBorderColor = System.Drawing.Color.White;
                buttons[i].ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
                buttons[i].ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
                buttons[i].ButtonHighlightForeColor = System.Drawing.Color.White;
                buttons[i].ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
                buttons[i].ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
                buttons[i].ButtonPressedForeColor = System.Drawing.Color.White;
                buttons[i].ButtonRoundRadius = 20;
                buttons[i].Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                buttons[i].ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                button.Click += new EventHandler(createFormAndProduct_Click);
                this.Controls.Add(button);
            }
        }

        private int priceOneProduct;
        private void createFormAndProduct_Click(object sender, EventArgs e)
        {

            RoundButton button = (RoundButton)sender;
            
            string buttonName = button.Text;
            VariableStorage.productName = buttonName;

            // Создаем новую форму
            dataForm.Text = $"{buttonName}";
            dataForm.StartPosition = FormStartPosition.CenterScreen;
            dataForm.Size = new Size(816, 489);
            dataForm.BackColor = Color.FromArgb(44, 44, 44);

            //Берём данные из БД
            DataTable tables = new DataTable();
            tables = functions.sqlSelect($"SELECT * FROM products WHERE name = '{buttonName}'");

            //Создаём объекты и накидываем на них данные
            //
            // header
            //
            Label header = new Label();
            header.Text = tables.Rows[0][1].ToString();
            header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            header.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            header.Location = new System.Drawing.Point(229, 106);
            header.Name = "header";
            header.Size = new System.Drawing.Size(559, 42);
            header.TabIndex = 9;
            header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dataForm.Controls.Add(header);
            // 
            // description
            // 
            Label description = new Label();
            description.Text = tables.Rows[0][2].ToString();
            description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            description.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            description.ForeColor = System.Drawing.Color.White;
            description.Location = new System.Drawing.Point(245, 266);
            description.Name = "description";
            description.Size = new System.Drawing.Size(543, 175);
            description.TabIndex = 0;
            dataForm.Controls.Add(description);
            // 
            // TextPrice
            //
            Label TextPrice = new Label();
            TextPrice.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            TextPrice.ForeColor = System.Drawing.Color.White;
            TextPrice.Location = new System.Drawing.Point(243, 180);
            TextPrice.Name = "TextPrice";
            TextPrice.Size = new System.Drawing.Size(94, 45);
            TextPrice.TabIndex = 5;
            TextPrice.Text = "Price:";
            dataForm.Controls.Add(TextPrice);
            // 
            // price
            //
            Label price = new Label();
            priceOneProduct = Convert.ToInt32(tables.Rows[0][3]);
            price.Text = tables.Rows[0][3].ToString() + "$";
            price.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            price.ForeColor = System.Drawing.Color.White;
            price.Location = new System.Drawing.Point(343, 180);
            price.Name = "price";
            price.Size = new System.Drawing.Size(94, 45);
            price.TabIndex = 7;
            dataForm.Controls.Add(price);
            // 
            // stockText
            // 
            Label stockText = new Label();
            stockText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            stockText.ForeColor = System.Drawing.Color.White;
            stockText.Location = new System.Drawing.Point(594, 180);
            stockText.Name = "stockText";
            stockText.Size = new System.Drawing.Size(94, 45);
            stockText.TabIndex = 8;
            stockText.Text = "Stock:";
            dataForm.Controls.Add(stockText);
            // 
            // stock
            //
            Label stock = new Label();
            stock.Text = tables.Rows[0][4].ToString();
            stock.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            stock.ForeColor = System.Drawing.Color.White;
            stock.Location = new System.Drawing.Point(694, 180);
            stock.Name = "stock";
            stock.Size = new System.Drawing.Size(94, 45);
            stock.TabIndex = 9;
            dataForm.Controls.Add(stock);
            // 
            // backButton
            //
            RoundButton backToCatalog = new RoundButton();
            backToCatalog = Buttons.createButtonBack();
            backToCatalog.Click += new System.EventHandler(this.backToCatalog_Click);
            dataForm.Controls.Add(backToCatalog);
            //
            //NumericUpDown
            //
            numericUpDown.Location = new System.Drawing.Point(405, 16);
            numericUpDown.Size = new System.Drawing.Size(121, 28);
            dataForm.Controls.Add(numericUpDown);
            //
            //cartButton
            //
            RoundButton cart = new RoundButton();
            cart = Buttons.createButtonCart();
            cart.Click += new System.EventHandler(this.goToCart_Click);
            dataForm.Controls.Add(cart);
            //
            //buyButton
            //
            RoundButton buy = new RoundButton();
            buy = Buttons.createButtonAddToCart();
            buy.Click += new System.EventHandler(this.goToAddToCart_Click);
            dataForm.Controls.Add(buy);
            // 
            // picture
            //
            PictureBox picture = new PictureBox();
            picture.Location = new System.Drawing.Point(12, 36);
            picture.Name = "pictureBox1";
            picture.Size = new System.Drawing.Size(211, 364);
            picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picture.TabIndex = 0;
            picture.TabStop = false;

            using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT Image FROM products WHERE '{buttonName}' = name", connection);
                byte[] imageData = (byte[])command.ExecuteScalar();
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    picture.Image = image;
                }
            }

            dataForm.Controls.Add(picture);

            this.Hide();
            dataForm.Show();
        }

        private void backToCatalog_Click(object sender, System.EventArgs e)
        {
            Catalog catalog = new Catalog();
            dataForm.Hide();
            catalog.Show();
        }

        private void backToActions_Click(object sender, System.EventArgs e)
        {
            ActionsInTheApplication actionsInTheApplication = new ActionsInTheApplication();
            this.Hide();
            actionsInTheApplication.Show();
        }

        private void goToCart1_Click(object sender, System.EventArgs e)
        {
            Cart cart = new Cart();
            this.Hide();
            cart.ShowDialog();
        }

        private void goToCart_Click(object sender, System.EventArgs e)
        {
            Cart cart = new Cart();
            dataForm.Hide();
            cart.ShowDialog();
        }

        private void goToAddToCart_Click(object sender, System.EventArgs e)
        {
            selectedValue = Convert.ToInt32(numericUpDown.Value);
            DataTable cheackQuantityOfProduct = new DataTable();

            cheackQuantityOfProduct = functions.sqlSelect($"SELECT stock FROM products WHERE '{VariableStorage.productName}' = name");
            if (Convert.ToInt32(cheackQuantityOfProduct.Rows[0][0]) < selectedValue)
            {
                MessageBox.Show("We don't have that much product", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (selectedValue == 0)
            {
                MessageBox.Show("Select the quantity of the product", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else  
            {
                if (checkQuantityProduct())
                {
                    if (checkProductInTheCart())
                    {
                        getUserID();
                        addingProductToOrders();
                        addingProductToOrderItem();
                    }
                    else
                    {
                        addProductInExistOrder();
                    }
                    
                }
                else
                {
                    MessageBox.Show("You have ordered too many items, check the shopping cart", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addProductInExistOrder()
        {
            DataTable quantityOrderItem = new DataTable();
            quantityOrderItem = functions.sqlSelect($"SELECT [quantity] FROM products JOIN order_item ON " +
                $"products.product_id = order_item.product_id WHERE products.[name] = '{VariableStorage.productName}' AND order_item.purchased = 0");
            int quantity = Convert.ToInt32(quantityOrderItem.Rows[0][0]);
            DataTable stockProductInDB = new DataTable();
            stockProductInDB = functions.sqlSelect($"SELECT stock FROM products WHERE [name] = '{VariableStorage.productName}'");
            int stockProduct = Convert.ToInt32(stockProductInDB.Rows[0][0]);
            quantity += selectedValue;
            if (quantity > stockProduct)
            {
                MessageBox.Show("You have ordered too many items, check the shopping cart", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable tableTakingSelectedProduct = new DataTable();
                tableTakingSelectedProduct = functions.sqlSelect($"SELECT product_id FROM products WHERE name = '{VariableStorage.productName}'");
                int productID = Convert.ToInt32(tableTakingSelectedProduct.Rows[0][0]);
                VariableStorage.globalProductID = productID;
                SqlCommand addToCart = new SqlCommand();
                addToCart = functions.sqlInsert($"UPDATE order_item SET quantity = {quantity} WHERE product_id = {productID} AND order_item.purchased = 0");
                if (addToCart.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("The product has been added to the cart", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private Boolean checkQuantityProduct()
        {
            DataTable orderedProducts = new DataTable();
            orderedProducts = functions.sqlSelect($"SELECT order_item.quantity FROM products JOIN order_item ON " +
                $"products.product_id = order_item.product_id WHERE [name] = '{VariableStorage.productName}' AND order_item.purchased = 0");
            int orderedProductsInCart = 0;
            foreach (DataRow row in orderedProducts.Rows)
            {
                int quantity = Convert.ToInt32(row["quantity"]);
                orderedProductsInCart += quantity;
            }
            DataTable stockProductInDB = new DataTable();
            stockProductInDB = functions.sqlSelect($"SELECT stock FROM products WHERE [name] = '{VariableStorage.productName}'");
            int stockProduct = Convert.ToInt32(stockProductInDB.Rows[0][0]);
            if (stockProduct < orderedProductsInCart)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addingProductToOrders()
        {
            DateTime currentDate = DateTime.Now;
            SqlCommand command = new SqlCommand();
            command = functions.sqlInsert($"INSERT INTO orders (customer_id, order_date) VALUES ('{getUserID()}', '{currentDate}');");
        }
        
        private void addingProductToOrderItem()
        {
            DataTable tableTakingSelectedProduct = new DataTable();
            tableTakingSelectedProduct = functions.sqlSelect($"SELECT product_id FROM products WHERE name = '{VariableStorage.productName}'");
            int productID = Convert.ToInt32(tableTakingSelectedProduct.Rows[0][0]);
            DataTable tableTakingOrderID = new DataTable();
            tableTakingOrderID = functions.sqlSelect($"SELECT id FROM orders WHERE customer_id = '{functions.getUserID()}'");
            int orderID = Convert.ToInt32(tableTakingOrderID.Rows[0][0]);
            //if
            SqlCommand addToCart = new SqlCommand();
            addToCart = functions.sqlInsert($"INSERT INTO order_item (order_id, product_id, quantity, purchased) VALUES('{orderID}', '{productID}', '{selectedValue}', '{0}')");
            if (addToCart.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("The product has been added to the cart", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public Boolean checkProductInTheCart()
        {
            DataTable getProduct = new DataTable();
            getProduct = functions.sqlSelect($"SELECT product_id FROM products WHERE [name] = '{VariableStorage.productName}'");
            int productID = Convert.ToInt32(getProduct.Rows[0][0]);
            DataTable getProcutInTheCart = new DataTable();
            getProcutInTheCart = functions.sqlSelect($"SELECT quantity FROM order_item WHERE order_item.product_id = {productID} AND order_item.purchased = 0");
            if (getProcutInTheCart.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int getUserID()
        {
            DataTable tableTakingUserID = new DataTable();
            tableTakingUserID = functions.sqlSelect($"SELECT id FROM customers WHERE username = '{VariableStorage.userName}'");
            int userID = Convert.ToInt32(tableTakingUserID.Rows[0][0]);
            return userID;
        }
    }
}
