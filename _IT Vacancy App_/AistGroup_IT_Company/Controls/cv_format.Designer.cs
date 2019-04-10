namespace AistGroup_IT_Company.Controls
{
    partial class CV_format
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_reject = new System.Windows.Forms.Label();
            this.txbx_reject_reason = new System.Windows.Forms.TextBox();
            this.btn_reason_send = new System.Windows.Forms.Button();
            this.cv_groupbox = new System.Windows.Forms.GroupBox();
            this.txbx_loadcv_salary = new System.Windows.Forms.Label();
            this.txbx_loadcv_skills = new System.Windows.Forms.Label();
            this.txbx_loadcv_email = new System.Windows.Forms.Label();
            this.txbx_loadcv_surname = new System.Windows.Forms.Label();
            this.txbx_loadcv_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_accept_reason = new System.Windows.Forms.Label();
            this.txbx_accept_reason = new System.Windows.Forms.TextBox();
            this.btn_accept_reason = new System.Windows.Forms.Button();
            this.cv_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(18, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Qəbul et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(138, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "İmtina et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_reject
            // 
            this.lbl_reject.AutoSize = true;
            this.lbl_reject.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl_reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_reject.Location = new System.Drawing.Point(15, 203);
            this.lbl_reject.Name = "lbl_reject";
            this.lbl_reject.Size = new System.Drawing.Size(143, 16);
            this.lbl_reject.TabIndex = 12;
            this.lbl_reject.Text = "İmtina səbəbini bildirin:";
            // 
            // txbx_reject_reason
            // 
            this.txbx_reject_reason.Location = new System.Drawing.Point(18, 222);
            this.txbx_reject_reason.Name = "txbx_reject_reason";
            this.txbx_reject_reason.Size = new System.Drawing.Size(329, 20);
            this.txbx_reject_reason.TabIndex = 13;
            // 
            // btn_reason_send
            // 
            this.btn_reason_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reason_send.Location = new System.Drawing.Point(138, 248);
            this.btn_reason_send.Name = "btn_reason_send";
            this.btn_reason_send.Size = new System.Drawing.Size(83, 26);
            this.btn_reason_send.TabIndex = 14;
            this.btn_reason_send.Text = "Təsdiq";
            this.btn_reason_send.UseVisualStyleBackColor = true;
            this.btn_reason_send.Click += new System.EventHandler(this.btn_reason_send_Click);
            // 
            // cv_groupbox
            // 
            this.cv_groupbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cv_groupbox.Controls.Add(this.txbx_loadcv_salary);
            this.cv_groupbox.Controls.Add(this.txbx_loadcv_skills);
            this.cv_groupbox.Controls.Add(this.txbx_loadcv_email);
            this.cv_groupbox.Controls.Add(this.txbx_loadcv_surname);
            this.cv_groupbox.Controls.Add(this.txbx_loadcv_name);
            this.cv_groupbox.Controls.Add(this.label7);
            this.cv_groupbox.Controls.Add(this.label8);
            this.cv_groupbox.Controls.Add(this.label9);
            this.cv_groupbox.Controls.Add(this.label10);
            this.cv_groupbox.Controls.Add(this.label11);
            this.cv_groupbox.Controls.Add(this.label12);
            this.cv_groupbox.Controls.Add(this.label13);
            this.cv_groupbox.Controls.Add(this.label14);
            this.cv_groupbox.Controls.Add(this.label15);
            this.cv_groupbox.Controls.Add(this.label16);
            this.cv_groupbox.ForeColor = System.Drawing.Color.Crimson;
            this.cv_groupbox.Location = new System.Drawing.Point(18, 14);
            this.cv_groupbox.Name = "cv_groupbox";
            this.cv_groupbox.Size = new System.Drawing.Size(235, 142);
            this.cv_groupbox.TabIndex = 15;
            this.cv_groupbox.TabStop = false;
            this.cv_groupbox.Text = "CV-1";
            // 
            // txbx_loadcv_salary
            // 
            this.txbx_loadcv_salary.AutoSize = true;
            this.txbx_loadcv_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_loadcv_salary.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txbx_loadcv_salary.Location = new System.Drawing.Point(95, 121);
            this.txbx_loadcv_salary.Name = "txbx_loadcv_salary";
            this.txbx_loadcv_salary.Size = new System.Drawing.Size(0, 16);
            this.txbx_loadcv_salary.TabIndex = 24;
            // 
            // txbx_loadcv_skills
            // 
            this.txbx_loadcv_skills.AutoSize = true;
            this.txbx_loadcv_skills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_loadcv_skills.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txbx_loadcv_skills.Location = new System.Drawing.Point(95, 97);
            this.txbx_loadcv_skills.Name = "txbx_loadcv_skills";
            this.txbx_loadcv_skills.Size = new System.Drawing.Size(0, 16);
            this.txbx_loadcv_skills.TabIndex = 23;
            // 
            // txbx_loadcv_email
            // 
            this.txbx_loadcv_email.AutoSize = true;
            this.txbx_loadcv_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_loadcv_email.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txbx_loadcv_email.Location = new System.Drawing.Point(95, 69);
            this.txbx_loadcv_email.Name = "txbx_loadcv_email";
            this.txbx_loadcv_email.Size = new System.Drawing.Size(0, 16);
            this.txbx_loadcv_email.TabIndex = 22;
            // 
            // txbx_loadcv_surname
            // 
            this.txbx_loadcv_surname.AutoSize = true;
            this.txbx_loadcv_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_loadcv_surname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txbx_loadcv_surname.Location = new System.Drawing.Point(95, 44);
            this.txbx_loadcv_surname.Name = "txbx_loadcv_surname";
            this.txbx_loadcv_surname.Size = new System.Drawing.Size(0, 16);
            this.txbx_loadcv_surname.TabIndex = 21;
            // 
            // txbx_loadcv_name
            // 
            this.txbx_loadcv_name.AutoSize = true;
            this.txbx_loadcv_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_loadcv_name.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txbx_loadcv_name.Location = new System.Drawing.Point(95, 16);
            this.txbx_loadcv_name.Name = "txbx_loadcv_name";
            this.txbx_loadcv_name.Size = new System.Drawing.Size(0, 16);
            this.txbx_loadcv_name.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(79, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(79, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(79, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(79, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(79, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(3, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Əmək haqqı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(28, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Biliklər:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(34, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(28, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "Soyad:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(45, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Ad:";
            // 
            // lbl_accept_reason
            // 
            this.lbl_accept_reason.AutoSize = true;
            this.lbl_accept_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_accept_reason.Location = new System.Drawing.Point(15, 203);
            this.lbl_accept_reason.Name = "lbl_accept_reason";
            this.lbl_accept_reason.Size = new System.Drawing.Size(246, 16);
            this.lbl_accept_reason.TabIndex = 16;
            this.lbl_accept_reason.Text = "Müsahibəyə çağırılma vaxtını qeyd edin:";
            // 
            // txbx_accept_reason
            // 
            this.txbx_accept_reason.Location = new System.Drawing.Point(18, 222);
            this.txbx_accept_reason.Name = "txbx_accept_reason";
            this.txbx_accept_reason.Size = new System.Drawing.Size(329, 20);
            this.txbx_accept_reason.TabIndex = 17;
            // 
            // btn_accept_reason
            // 
            this.btn_accept_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_accept_reason.Location = new System.Drawing.Point(138, 248);
            this.btn_accept_reason.Name = "btn_accept_reason";
            this.btn_accept_reason.Size = new System.Drawing.Size(83, 26);
            this.btn_accept_reason.TabIndex = 18;
            this.btn_accept_reason.Text = "Təsdiq";
            this.btn_accept_reason.UseVisualStyleBackColor = true;
            this.btn_accept_reason.Click += new System.EventHandler(this.btn_accept_reason_Click);
            // 
            // CV_format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_accept_reason);
            this.Controls.Add(this.txbx_accept_reason);
            this.Controls.Add(this.lbl_accept_reason);
            this.Controls.Add(this.cv_groupbox);
            this.Controls.Add(this.btn_reason_send);
            this.Controls.Add(this.txbx_reject_reason);
            this.Controls.Add(this.lbl_reject);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CV_format";
            this.Size = new System.Drawing.Size(363, 283);
            this.Load += new System.EventHandler(this.CV_format_Load);
            this.cv_groupbox.ResumeLayout(false);
            this.cv_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_reject;
        public System.Windows.Forms.TextBox txbx_reject_reason;
        private System.Windows.Forms.Button btn_reason_send;
        public System.Windows.Forms.GroupBox cv_groupbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label txbx_loadcv_surname;
        public System.Windows.Forms.Label txbx_loadcv_name;
        public System.Windows.Forms.Label txbx_loadcv_salary;
        public System.Windows.Forms.Label txbx_loadcv_skills;
        public System.Windows.Forms.Label txbx_loadcv_email;
        private System.Windows.Forms.Label lbl_accept_reason;
        private System.Windows.Forms.TextBox txbx_accept_reason;
        private System.Windows.Forms.Button btn_accept_reason;
    }
}
