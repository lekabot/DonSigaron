using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    partial class Address
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
            this.text_address = new System.Windows.Forms.TextBox();
            this.label_passwd = new System.Windows.Forms.Label();
            this.roundButton1 = new RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_address
            // 
            this.text_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.text_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_address.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_address.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.text_address.Location = new System.Drawing.Point(310, 228);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(167, 35);
            this.text_address.TabIndex = 10;
            // 
            // label_passwd
            // 
            this.label_passwd.AutoSize = true;
            this.label_passwd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_passwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_passwd.Location = new System.Drawing.Point(228, 233);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(76, 23);
            this.label_passwd.TabIndex = 12;
            this.label_passwd.Text = "Address";
            // 
            // roundButton1
            // 
            this.roundButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundButton1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.White;
            this.roundButton1.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 20;
            this.roundButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton1.Location = new System.Drawing.Point(291, 320);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(206, 53);
            this.roundButton1.TabIndex = 15;
            this.roundButton1.Text = "Add address";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(284, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add address";
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label_passwd);
            this.Controls.Add(this.text_address);
            this.Name = "Address";
            this.Text = "Address";
            this.Load += new System.EventHandler(this.Address_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton1;
    }
}