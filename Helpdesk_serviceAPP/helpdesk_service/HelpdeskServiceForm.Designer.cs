namespace helpdesk_service
{
    partial class HelpdeskServiceForm
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
            this.lbl_helpdesk_servicePrice = new System.Windows.Forms.Label();
            this.lbl_helpdesk_serviceID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.user_current_money = new System.Windows.Forms.Label();
            this.lbl_helpdesk_serviceName = new System.Windows.Forms.LinkLabel();
            this.txbx_id_service = new System.Windows.Forms.TextBox();
            this.btn_buy_service = new System.Windows.Forms.Button();
            this.lbl_service_idText = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Helpdesk xidmətləri";
            // 
            // lbl_helpdesk_servicePrice
            // 
            this.lbl_helpdesk_servicePrice.AutoSize = true;
            this.lbl_helpdesk_servicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_helpdesk_servicePrice.Location = new System.Drawing.Point(338, 112);
            this.lbl_helpdesk_servicePrice.Name = "lbl_helpdesk_servicePrice";
            this.lbl_helpdesk_servicePrice.Size = new System.Drawing.Size(0, 16);
            this.lbl_helpdesk_servicePrice.TabIndex = 2;
            // 
            // lbl_helpdesk_serviceID
            // 
            this.lbl_helpdesk_serviceID.AutoSize = true;
            this.lbl_helpdesk_serviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_helpdesk_serviceID.Location = new System.Drawing.Point(11, 109);
            this.lbl_helpdesk_serviceID.Name = "lbl_helpdesk_serviceID";
            this.lbl_helpdesk_serviceID.Size = new System.Drawing.Size(0, 16);
            this.lbl_helpdesk_serviceID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xidmətin adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(338, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Qiyməti";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(460, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Balansı artır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Balansınız:";
            // 
            // user_current_money
            // 
            this.user_current_money.AutoSize = true;
            this.user_current_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_current_money.Location = new System.Drawing.Point(84, 9);
            this.user_current_money.Name = "user_current_money";
            this.user_current_money.Size = new System.Drawing.Size(0, 16);
            this.user_current_money.TabIndex = 9;
            // 
            // lbl_helpdesk_serviceName
            // 
            this.lbl_helpdesk_serviceName.AutoSize = true;
            this.lbl_helpdesk_serviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_helpdesk_serviceName.Location = new System.Drawing.Point(37, 109);
            this.lbl_helpdesk_serviceName.Name = "lbl_helpdesk_serviceName";
            this.lbl_helpdesk_serviceName.Size = new System.Drawing.Size(0, 16);
            this.lbl_helpdesk_serviceName.TabIndex = 11;
            this.lbl_helpdesk_serviceName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_helpdesk_serviceName_LinkClicked);
            // 
            // txbx_id_service
            // 
            this.txbx_id_service.Location = new System.Drawing.Point(416, 112);
            this.txbx_id_service.Name = "txbx_id_service";
            this.txbx_id_service.Size = new System.Drawing.Size(75, 20);
            this.txbx_id_service.TabIndex = 12;
            // 
            // btn_buy_service
            // 
            this.btn_buy_service.Location = new System.Drawing.Point(416, 138);
            this.btn_buy_service.Name = "btn_buy_service";
            this.btn_buy_service.Size = new System.Drawing.Size(75, 23);
            this.btn_buy_service.TabIndex = 13;
            this.btn_buy_service.Text = "Təsdiqlə";
            this.btn_buy_service.UseVisualStyleBackColor = true;
            this.btn_buy_service.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_service_idText
            // 
            this.lbl_service_idText.AutoSize = true;
            this.lbl_service_idText.Location = new System.Drawing.Point(413, 90);
            this.lbl_service_idText.Name = "lbl_service_idText";
            this.lbl_service_idText.Size = new System.Drawing.Size(74, 13);
            this.lbl_service_idText.TabIndex = 14;
            this.lbl_service_idText.Text = "İd-ni daxil edin";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(460, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "İdarəetmə paneli";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(5, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Çıxış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HelpdeskServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 428);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_service_idText);
            this.Controls.Add(this.btn_buy_service);
            this.Controls.Add(this.txbx_id_service);
            this.Controls.Add(this.lbl_helpdesk_serviceName);
            this.Controls.Add(this.user_current_money);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_helpdesk_serviceID);
            this.Controls.Add(this.lbl_helpdesk_servicePrice);
            this.Controls.Add(this.label1);
            this.Name = "HelpdeskServiceForm";
            this.Text = "Helpdesk xitmətlərinin satışı formu";
            this.Load += new System.EventHandler(this.HelpdeskServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_helpdesk_servicePrice;
        private System.Windows.Forms.Label lbl_helpdesk_serviceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label user_current_money;
        private System.Windows.Forms.LinkLabel lbl_helpdesk_serviceName;
        private System.Windows.Forms.TextBox txbx_id_service;
        private System.Windows.Forms.Button btn_buy_service;
        private System.Windows.Forms.Label lbl_service_idText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}