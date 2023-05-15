using DonSigaron.Classes;

namespace DonSigaron.Forms
{
    partial class AddPaymethod
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
            this.textBox_CVV = new System.Windows.Forms.TextBox();
            this.cvv = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.roundButton1 = new RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.MaskedTextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_CVV
            // 
            this.textBox_CVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox_CVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CVV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CVV.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_CVV.Location = new System.Drawing.Point(288, 270);
            this.textBox_CVV.Name = "textBox_CVV";
            this.textBox_CVV.Size = new System.Drawing.Size(230, 35);
            this.textBox_CVV.TabIndex = 87;
            // 
            // cvv
            // 
            this.cvv.AutoSize = true;
            this.cvv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cvv.Location = new System.Drawing.Point(228, 275);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(54, 23);
            this.cvv.TabIndex = 86;
            this.cvv.Text = "CVV";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.date.Location = new System.Drawing.Point(233, 219);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(49, 23);
            this.date.TabIndex = 85;
            this.date.Text = "Date";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.number.Location = new System.Drawing.Point(206, 158);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(78, 23);
            this.number.TabIndex = 83;
            this.number.Text = "Number";
            // 
            // roundButton1
            // 
            this.roundButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.roundButton1.Location = new System.Drawing.Point(291, 345);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(225, 53);
            this.roundButton1.TabIndex = 81;
            this.roundButton1.Text = "Sign up";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(304, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 42);
            this.label1.TabIndex = 80;
            this.label1.Text = "Registration";
            // 
            // textBox_date
            // 
            this.textBox_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_date.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_date.Location = new System.Drawing.Point(288, 214);
            this.textBox_date.Mask = "00/00/0000";
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(231, 35);
            this.textBox_date.TabIndex = 88;
            this.textBox_date.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_number
            // 
            this.textBox_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_number.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_number.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_number.Location = new System.Drawing.Point(288, 153);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(230, 35);
            this.textBox_number.TabIndex = 90;
            // 
            // AddPaymethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_CVV);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.date);
            this.Controls.Add(this.number);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label1);
            this.Name = "AddPaymethod";
            this.Text = "AddPaymethod";
            this.Load += new System.EventHandler(this.AddPaymethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CVV;
        private System.Windows.Forms.Label cvv;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton1;
        private System.Windows.Forms.MaskedTextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_number;
    }
}