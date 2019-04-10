namespace AistGroup_IT_Company
{
    partial class CompanyVacanciesForm
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
            this.vacacies_content = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_form_user = new System.Windows.Forms.Label();
            this.form_current_user = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.user_information_checking = new System.Windows.Forms.Button();
            this.lbl_response_result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vacacies_content
            // 
            this.vacacies_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacacies_content.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vacacies_content.Location = new System.Drawing.Point(5, 56);
            this.vacacies_content.Name = "vacacies_content";
            this.vacacies_content.Size = new System.Drawing.Size(726, 324);
            this.vacacies_content.TabIndex = 0;
            this.vacacies_content.TabStop = false;
            this.vacacies_content.Text = "Vacancies";
            this.vacacies_content.Enter += new System.EventHandler(this.vacacies_content_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xoş gəlmisiniz:";
            // 
            // txbx_form_user
            // 
            this.txbx_form_user.AutoSize = true;
            this.txbx_form_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_form_user.ForeColor = System.Drawing.Color.DarkBlue;
            this.txbx_form_user.Location = new System.Drawing.Point(594, 9);
            this.txbx_form_user.Name = "txbx_form_user";
            this.txbx_form_user.Size = new System.Drawing.Size(0, 16);
            this.txbx_form_user.TabIndex = 2;
            // 
            // form_current_user
            // 
            this.form_current_user.AutoSize = true;
            this.form_current_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_current_user.ForeColor = System.Drawing.Color.DarkBlue;
            this.form_current_user.Location = new System.Drawing.Point(104, 9);
            this.form_current_user.Name = "form_current_user";
            this.form_current_user.Size = new System.Drawing.Size(0, 16);
            this.form_current_user.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(620, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(106, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Senansı bitir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // user_information_checking
            // 
            this.user_information_checking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_information_checking.Location = new System.Drawing.Point(517, 6);
            this.user_information_checking.Name = "user_information_checking";
            this.user_information_checking.Size = new System.Drawing.Size(97, 23);
            this.user_information_checking.TabIndex = 5;
            this.user_information_checking.Text = "Şəxsi Kabinet";
            this.user_information_checking.UseVisualStyleBackColor = true;
            this.user_information_checking.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_response_result
            // 
            this.lbl_response_result.AutoSize = true;
            this.lbl_response_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_response_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_response_result.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_response_result.Location = new System.Drawing.Point(514, 37);
            this.lbl_response_result.Name = "lbl_response_result";
            this.lbl_response_result.Size = new System.Drawing.Size(0, 16);
            this.lbl_response_result.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(620, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Formu bağla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CompanyVacanciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_response_result);
            this.Controls.Add(this.user_information_checking);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.form_current_user);
            this.Controls.Add(this.txbx_form_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vacacies_content);
            this.Name = "CompanyVacanciesForm";
            this.Text = "CompanyVacanciesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyVacanciesForm_FormClosed);
            this.Load += new System.EventHandler(this.CompanyVacanciesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox vacacies_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txbx_form_user;
        private System.Windows.Forms.Label form_current_user;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button user_information_checking;
        private System.Windows.Forms.Label lbl_response_result;
        private System.Windows.Forms.Button button1;
    }
}