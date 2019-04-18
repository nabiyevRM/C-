namespace helpdesk_service
{
    partial class UserRegistrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reg_without_card = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_reg_confirm_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_reg_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_reg_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_reg_surname = new System.Windows.Forms.TextBox();
            this.Name_ = new System.Windows.Forms.Label();
            this.txbx_reg_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_regWithCard_cardNumber = new System.Windows.Forms.TextBox();
            this.btn_reg_with_card = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_regWithCard_confirm_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_regWithCard_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbx_regWithCard_email = new System.Windows.Forms.TextBox();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reg_without_card);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbx_reg_confirm_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_reg_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbx_reg_email);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbx_reg_surname);
            this.groupBox1.Controls.Add(this.Name_);
            this.groupBox1.Controls.Add(this.txbx_reg_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 358);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kartsız Qeydiyyat:";
            // 
            // btn_reg_without_card
            // 
            this.btn_reg_without_card.ForeColor = System.Drawing.Color.Crimson;
            this.btn_reg_without_card.Location = new System.Drawing.Point(70, 314);
            this.btn_reg_without_card.Name = "btn_reg_without_card";
            this.btn_reg_without_card.Size = new System.Drawing.Size(80, 27);
            this.btn_reg_without_card.TabIndex = 10;
            this.btn_reg_without_card.Text = "Qeydiyyat";
            this.btn_reg_without_card.UseVisualStyleBackColor = true;
            this.btn_reg_without_card.Click += new System.EventHandler(this.btn_reg_without_card_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Təsdiq şifrə:";
            // 
            // txbx_reg_confirm_password
            // 
            this.txbx_reg_confirm_password.Location = new System.Drawing.Point(18, 276);
            this.txbx_reg_confirm_password.Name = "txbx_reg_confirm_password";
            this.txbx_reg_confirm_password.PasswordChar = '*';
            this.txbx_reg_confirm_password.Size = new System.Drawing.Size(194, 22);
            this.txbx_reg_confirm_password.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifrə:";
            // 
            // txbx_reg_password
            // 
            this.txbx_reg_password.Location = new System.Drawing.Point(18, 219);
            this.txbx_reg_password.Name = "txbx_reg_password";
            this.txbx_reg_password.PasswordChar = '*';
            this.txbx_reg_password.Size = new System.Drawing.Size(194, 22);
            this.txbx_reg_password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elektron poçt:";
            // 
            // txbx_reg_email
            // 
            this.txbx_reg_email.Location = new System.Drawing.Point(18, 162);
            this.txbx_reg_email.Name = "txbx_reg_email";
            this.txbx_reg_email.Size = new System.Drawing.Size(194, 22);
            this.txbx_reg_email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soyad:";
            // 
            // txbx_reg_surname
            // 
            this.txbx_reg_surname.Location = new System.Drawing.Point(18, 105);
            this.txbx_reg_surname.Name = "txbx_reg_surname";
            this.txbx_reg_surname.Size = new System.Drawing.Size(194, 22);
            this.txbx_reg_surname.TabIndex = 2;
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.Location = new System.Drawing.Point(15, 25);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(28, 16);
            this.Name_.TabIndex = 1;
            this.Name_.Text = "Ad:";
            // 
            // txbx_reg_name
            // 
            this.txbx_reg_name.Location = new System.Drawing.Point(18, 48);
            this.txbx_reg_name.Name = "txbx_reg_name";
            this.txbx_reg_name.Size = new System.Drawing.Size(194, 22);
            this.txbx_reg_name.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbx_regWithCard_cardNumber);
            this.groupBox2.Controls.Add(this.btn_reg_with_card);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbx_regWithCard_confirm_password);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbx_regWithCard_password);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbx_regWithCard_email);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(310, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 298);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kartnan Qeydiyyat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Card number:";
            // 
            // txbx_regWithCard_cardNumber
            // 
            this.txbx_regWithCard_cardNumber.Location = new System.Drawing.Point(26, 48);
            this.txbx_regWithCard_cardNumber.Name = "txbx_regWithCard_cardNumber";
            this.txbx_regWithCard_cardNumber.Size = new System.Drawing.Size(194, 22);
            this.txbx_regWithCard_cardNumber.TabIndex = 18;
            // 
            // btn_reg_with_card
            // 
            this.btn_reg_with_card.ForeColor = System.Drawing.Color.Crimson;
            this.btn_reg_with_card.Location = new System.Drawing.Point(78, 257);
            this.btn_reg_with_card.Name = "btn_reg_with_card";
            this.btn_reg_with_card.Size = new System.Drawing.Size(80, 27);
            this.btn_reg_with_card.TabIndex = 17;
            this.btn_reg_with_card.Text = "Qeydiyyat";
            this.btn_reg_with_card.UseVisualStyleBackColor = true;
            this.btn_reg_with_card.Click += new System.EventHandler(this.btn_reg_with_card_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Təsdiq şifrə:";
            // 
            // txbx_regWithCard_confirm_password
            // 
            this.txbx_regWithCard_confirm_password.Location = new System.Drawing.Point(26, 219);
            this.txbx_regWithCard_confirm_password.Name = "txbx_regWithCard_confirm_password";
            this.txbx_regWithCard_confirm_password.PasswordChar = '*';
            this.txbx_regWithCard_confirm_password.Size = new System.Drawing.Size(194, 22);
            this.txbx_regWithCard_confirm_password.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Şifrə:";
            // 
            // txbx_regWithCard_password
            // 
            this.txbx_regWithCard_password.Location = new System.Drawing.Point(26, 162);
            this.txbx_regWithCard_password.Name = "txbx_regWithCard_password";
            this.txbx_regWithCard_password.PasswordChar = '*';
            this.txbx_regWithCard_password.Size = new System.Drawing.Size(194, 22);
            this.txbx_regWithCard_password.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Elektron poçt:";
            // 
            // txbx_regWithCard_email
            // 
            this.txbx_regWithCard_email.Location = new System.Drawing.Point(26, 105);
            this.txbx_regWithCard_email.Name = "txbx_regWithCard_email";
            this.txbx_regWithCard_email.Size = new System.Drawing.Size(194, 22);
            this.txbx_regWithCard_email.TabIndex = 11;
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.Location = new System.Drawing.Point(307, 361);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(0, 13);
            this.lbl_errors.TabIndex = 4;
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(597, 476);
            this.Controls.Add(this.lbl_errors);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserRegistrationForm";
            this.Text = "Qeydiyyat Formu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reg_without_card;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_reg_confirm_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_reg_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_reg_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_reg_surname;
        private System.Windows.Forms.Label Name_;
        private System.Windows.Forms.TextBox txbx_reg_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_regWithCard_cardNumber;
        private System.Windows.Forms.Button btn_reg_with_card;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_regWithCard_confirm_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_regWithCard_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbx_regWithCard_email;
        private System.Windows.Forms.Label lbl_errors;
    }
}

