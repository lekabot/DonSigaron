using System;
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
