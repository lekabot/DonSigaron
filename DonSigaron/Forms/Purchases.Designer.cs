using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    partial class Purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchases));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.obtain = new System.Windows.Forms.ComboBox();
            this.payment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addObtain = new System.Windows.Forms.Button();
            this.addPayment = new System.Windows.Forms.Button();
            this.addAddress = new RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(256, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 66;
            this.label1.Text = "Making an order";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(524, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 67;
            this.label2.Text = "Payment method";
            // 
            // obtain
            // 
            this.obtain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obtain.FormattingEnabled = true;
            this.obtain.Location = new System.Drawing.Point(10, 211);
            this.obtain.Name = "obtain";
            this.obtain.Size = new System.Drawing.Size(295, 26);
            this.obtain.TabIndex = 68;
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payment.FormattingEnabled = true;
            this.payment.Location = new System.Drawing.Point(459, 211);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(295, 26);
            this.payment.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(74, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 69;
            this.label3.Text = "Delivery point";
            // 
            // addObtain
            // 
            this.addObtain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addObtain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addObtain.Image = ((System.Drawing.Image)(resources.GetObject("addObtain.Image")));
            this.addObtain.Location = new System.Drawing.Point(760, 210);
            this.addObtain.Name = "addObtain";
            this.addObtain.Size = new System.Drawing.Size(28, 28);
            this.addObtain.TabIndex = 71;
            this.addObtain.Text = "\r\n";
            this.addObtain.UseVisualStyleBackColor = true;
            this.addObtain.Click += new System.EventHandler(this.addObtain_Click);
            // 
            // addPayment
            // 
            this.addPayment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addPayment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addPayment.Image = ((System.Drawing.Image)(resources.GetObject("addPayment.Image")));
            this.addPayment.Location = new System.Drawing.Point(311, 211);
            this.addPayment.Name = "addPayment";
            this.addPayment.Size = new System.Drawing.Size(28, 28);
            this.addPayment.TabIndex = 72;
            this.addPayment.Text = "\r\n";
            this.addPayment.UseVisualStyleBackColor = true;
            this.addPayment.Click += new System.EventHandler(this.addPayment_Click);
            // 
            // addAddress
            // 
            this.addAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.addAddress.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.addAddress.ButtonBorderColor = System.Drawing.Color.White;
            this.addAddress.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.addAddress.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.addAddress.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.addAddress.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.addAddress.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.addAddress.ButtonPressedForeColor = System.Drawing.Color.White;
            this.addAddress.ButtonRoundRadius = 20;
            this.addAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addAddress.Location = new System.Drawing.Point(289, 326);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(225, 53);
            this.addAddress.TabIndex = 65;
            this.addAddress.Text = "Buy";
            this.addAddress.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPayment);
            this.Controls.Add(this.addObtain);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.obtain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAddress);
            this.Name = "Purchase";
            this.Text = "Design";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox obtain;
        private System.Windows.Forms.ComboBox payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addObtain;
        private System.Windows.Forms.Button addPayment;
        private RoundButton addAddress;
    }
}