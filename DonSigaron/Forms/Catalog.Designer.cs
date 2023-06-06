using System.Reflection.Emit;
using System.Windows.Forms;
using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    partial class Catalog
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
            this.SuspendLayout();
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(742, 325);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load_1);
            this.SizeChanged += new System.EventHandler(this.Catalog_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label stockText;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label TextPrice;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label header;
    }
}