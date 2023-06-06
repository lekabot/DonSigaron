using System;
using System.Drawing;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    public partial class ActionsInTheApplication : Form
    {
        public ActionsInTheApplication()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            BackButton();
        }

        private void BackButton()
        {
            RoundButton cart = new RoundButton();
            cart = Buttons.createButtonBack();
            cart.Location = new Point(this.ClientSize.Width - cart.Width - 10, 10);
            cart.Click += new System.EventHandler(this.LogOut);
            this.Controls.Add(cart);
        }

        private void LogOut(object sender, EventArgs e)
        {
            var main = new MainForm();
            this.Hide();
            main.Show();
        }

        private void shopBT_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            this.Hide();
            catalog.Show();
        }

        private void checkInfoBT_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            this.Hide();
            information.Show();
        }

        private void goToCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }
    }
}
