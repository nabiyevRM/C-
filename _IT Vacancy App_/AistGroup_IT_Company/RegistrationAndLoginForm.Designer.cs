using System.Windows.Forms;

namespace AistGroup_IT_Company
{
    partial class RegistrationAndLoginForm
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
            this.error_list = new System.Windows.Forms.Label();
            this.txbx_reg_btn = new System.Windows.Forms.Button();
            this.txbx_reg_confirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_reg_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_reg_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_reg_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_reg_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbx_log_btn = new System.Windows.Forms.Button();
            this.txbx_log_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_log_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errors_list = new System.Windows.Forms.Label();
            this.show_errors = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.error_list);
            this.groupBox1.Controls.Add(this.txbx_reg_btn);
            this.groupBox1.Controls.Add(this.txbx_reg_confirmPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbx_reg_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbx_reg_email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbx_reg_surname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_reg_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qeydiyyat bölməsi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // error_list
            // 
            this.error_list.AutoSize = true;
            this.error_list.Location = new System.Drawing.Point(15, 76);
            this.error_list.Name = "error_list";
            this.error_list.Size = new System.Drawing.Size(0, 16);
            this.error_list.TabIndex = 2;
            // 
            // txbx_reg_btn
            // 
            this.txbx_reg_btn.Location = new System.Drawing.Point(70, 319);
            this.txbx_reg_btn.Name = "txbx_reg_btn";
            this.txbx_reg_btn.Size = new System.Drawing.Size(98, 29);
            this.txbx_reg_btn.TabIndex = 1;
            this.txbx_reg_btn.Text = "Qeydiyyat";
            this.txbx_reg_btn.UseVisualStyleBackColor = true;
            this.txbx_reg_btn.Click += new System.EventHandler(this.txbx_reg_btn_Click);
            // 
            // txbx_reg_confirmPassword
            // 
            this.txbx_reg_confirmPassword.Location = new System.Drawing.Point(15, 282);
            this.txbx_reg_confirmPassword.Name = "txbx_reg_confirmPassword";
            this.txbx_reg_confirmPassword.PasswordChar = '*';
            this.txbx_reg_confirmPassword.Size = new System.Drawing.Size(220, 22);
            this.txbx_reg_confirmPassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Təsdiq şifrəsi:";
            // 
            // txbx_reg_password
            // 
            this.txbx_reg_password.Location = new System.Drawing.Point(15, 231);
            this.txbx_reg_password.Name = "txbx_reg_password";
            this.txbx_reg_password.PasswordChar = '*';
            this.txbx_reg_password.Size = new System.Drawing.Size(220, 22);
            this.txbx_reg_password.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifrə:";
            // 
            // txbx_reg_email
            // 
            this.txbx_reg_email.Location = new System.Drawing.Point(15, 172);
            this.txbx_reg_email.Name = "txbx_reg_email";
            this.txbx_reg_email.Size = new System.Drawing.Size(220, 22);
            this.txbx_reg_email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Elektron poçt ünvanız:";
            // 
            // txbx_reg_surname
            // 
            this.txbx_reg_surname.Location = new System.Drawing.Point(15, 114);
            this.txbx_reg_surname.Name = "txbx_reg_surname";
            this.txbx_reg_surname.Size = new System.Drawing.Size(220, 22);
            this.txbx_reg_surname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad:";
            // 
            // txbx_reg_name
            // 
            this.txbx_reg_name.Location = new System.Drawing.Point(15, 53);
            this.txbx_reg_name.Name = "txbx_reg_name";
            this.txbx_reg_name.Size = new System.Drawing.Size(220, 22);
            this.txbx_reg_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbx_log_btn);
            this.groupBox2.Controls.Add(this.txbx_log_password);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbx_log_email);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistemə daxil olun";
            // 
            // txbx_log_btn
            // 
            this.txbx_log_btn.Location = new System.Drawing.Point(78, 153);
            this.txbx_log_btn.Name = "txbx_log_btn";
            this.txbx_log_btn.Size = new System.Drawing.Size(86, 28);
            this.txbx_log_btn.TabIndex = 13;
            this.txbx_log_btn.Text = "Daxil ol";
            this.txbx_log_btn.UseVisualStyleBackColor = true;
            this.txbx_log_btn.Click += new System.EventHandler(this.txbx_log_btn_Click);
            // 
            // txbx_log_password
            // 
            this.txbx_log_password.Location = new System.Drawing.Point(17, 114);
            this.txbx_log_password.Name = "txbx_log_password";
            this.txbx_log_password.PasswordChar = '*';
            this.txbx_log_password.Size = new System.Drawing.Size(220, 22);
            this.txbx_log_password.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şifrə:";
            // 
            // txbx_log_email
            // 
            this.txbx_log_email.Location = new System.Drawing.Point(17, 53);
            this.txbx_log_email.Name = "txbx_log_email";
            this.txbx_log_email.Size = new System.Drawing.Size(220, 22);
            this.txbx_log_email.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(14, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Elektron poçt ünvanız:";
            // 
            // errors_list
            // 
            this.errors_list.AutoSize = true;
            this.errors_list.Location = new System.Drawing.Point(284, 257);
            this.errors_list.Name = "errors_list";
            this.errors_list.Size = new System.Drawing.Size(0, 13);
            this.errors_list.TabIndex = 11;
            // 
            // show_errors
            // 
            this.show_errors.AutoSize = true;
            this.show_errors.Location = new System.Drawing.Point(301, 251);
            this.show_errors.Name = "show_errors";
            this.show_errors.Size = new System.Drawing.Size(0, 13);
            this.show_errors.TabIndex = 12;
            // 
            // RegistrationAndLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 382);
            this.Controls.Add(this.show_errors);
            this.Controls.Add(this.errors_list);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationAndLoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistrationAndLoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txbx_reg_btn;
        private System.Windows.Forms.TextBox txbx_reg_confirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_reg_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_reg_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_reg_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_reg_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txbx_log_btn;
        private System.Windows.Forms.TextBox txbx_log_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_log_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label error_list;
        private Label errors_list;
        private System.Windows.Forms.Label txbx_errors_list;
        private Label show_errors;
    }
}

