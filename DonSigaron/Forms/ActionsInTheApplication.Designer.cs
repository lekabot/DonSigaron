using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    partial class ActionsInTheApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shopBT = new RoundButton();
            this.checkInfoBT = new RoundButton();
            this.goToCart = new RoundButton();
            this.SuspendLayout();
            // 
            // shopBT
            // 
            this.shopBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.shopBT.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.shopBT.ButtonBorderColor = System.Drawing.Color.White;
            this.shopBT.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.shopBT.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.shopBT.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.shopBT.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.shopBT.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.shopBT.ButtonPressedForeColor = System.Drawing.Color.White;
            this.shopBT.ButtonRoundRadius = 20;
            this.shopBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shopBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shopBT.Location = new System.Drawing.Point(328, 404);
            this.shopBT.Name = "shopBT";
            this.shopBT.Size = new System.Drawing.Size(190, 66);
            this.shopBT.TabIndex = 5;
            this.shopBT.Text = "Shop";
            this.shopBT.Click += new System.EventHandler(this.shopBT_Click);
            // 
            // checkInfoBT
            // 
            this.checkInfoBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.checkInfoBT.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.checkInfoBT.ButtonBorderColor = System.Drawing.Color.White;
            this.checkInfoBT.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkInfoBT.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkInfoBT.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.checkInfoBT.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.checkInfoBT.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.checkInfoBT.ButtonPressedForeColor = System.Drawing.Color.White;
            this.checkInfoBT.ButtonRoundRadius = 20;
            this.checkInfoBT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkInfoBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkInfoBT.Location = new System.Drawing.Point(328, 332);
            this.checkInfoBT.Name = "checkInfoBT";
            this.checkInfoBT.Size = new System.Drawing.Size(190, 66);
            this.checkInfoBT.TabIndex = 4;
            this.checkInfoBT.Text = "Informations";
            this.checkInfoBT.Click += new System.EventHandler(this.checkInfoBT_Click);
            // 
            // goToCart
            // 
            this.goToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.goToCart.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.goToCart.ButtonBorderColor = System.Drawing.Color.White;
            this.goToCart.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.goToCart.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.goToCart.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.goToCart.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.goToCart.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.goToCart.ButtonPressedForeColor = System.Drawing.Color.White;
            this.goToCart.ButtonRoundRadius = 20;
            this.goToCart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goToCart.Location = new System.Drawing.Point(328, 260);
            this.goToCart.Name = "goToCart";
            this.goToCart.Size = new System.Drawing.Size(190, 66);
            this.goToCart.TabIndex = 6;
            this.goToCart.Text = "Cart";
            this.goToCart.Click += new System.EventHandler(this.goToCart_Click);
            // 
            // ActionsInTheApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.goToCart);
            this.Controls.Add(this.shopBT);
            this.Controls.Add(this.checkInfoBT);
            this.Name = "ActionsInTheApplication";
            this.Text = "ActionsInTheApplication";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton shopBT;
        private RoundButton checkInfoBT;
        private RoundButton goToCart;
    }
}