namespace helpdesk_service
{
    partial class PaymentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_bank_card_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_expiry_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_payment_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_cvc_number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart nömrəsi:";
            // 
            // txbx_bank_card_number
            // 
            this.txbx_bank_card_number.Location = new System.Drawing.Point(15, 55);
            this.txbx_bank_card_number.Name = "txbx_bank_card_number";
            this.txbx_bank_card_number.Size = new System.Drawing.Size(234, 20);
            this.txbx_bank_card_number.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitmə tarixi:";
            // 
            // txbx_expiry_date
            // 
            this.txbx_expiry_date.Location = new System.Drawing.Point(15, 106);
            this.txbx_expiry_date.Name = "txbx_expiry_date";
            this.txbx_expiry_date.Size = new System.Drawing.Size(72, 20);
            this.txbx_expiry_date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(170, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Məbləğ:";
            // 
            // txbx_payment_amount
            // 
            this.txbx_payment_amount.Location = new System.Drawing.Point(173, 106);
            this.txbx_payment_amount.Name = "txbx_payment_amount";
            this.txbx_payment_amount.Size = new System.Drawing.Size(54, 20);
            this.txbx_payment_amount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(102, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CVC:";
            // 
            // txbx_cvc_number
            // 
            this.txbx_cvc_number.Location = new System.Drawing.Point(105, 106);
            this.txbx_cvc_number.Name = "txbx_cvc_number";
            this.txbx_cvc_number.Size = new System.Drawing.Size(46, 20);
            this.txbx_cvc_number.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(76, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Təsdiqlə";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbx_cvc_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_payment_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_expiry_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_bank_card_number);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_bank_card_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_expiry_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_payment_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_cvc_number;
        private System.Windows.Forms.Button button1;
    }
}