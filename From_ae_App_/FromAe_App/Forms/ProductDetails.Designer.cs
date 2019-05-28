namespace Admin_Form.Forms
{
    partial class ProductDetails
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
            this.productBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_form_user = new System.Windows.Forms.Label();
            this.btn_back_page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productBox
            // 
            this.productBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.productBox.Location = new System.Drawing.Point(12, 62);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(744, 526);
            this.productBox.TabIndex = 0;
            this.productBox.TabStop = false;
            this.productBox.Text = "Seçilmiş məhsul";
            this.productBox.Enter += new System.EventHandler(this.productBox_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(653, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Çıxış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "İstifadəçi:";
            // 
            // lbl_form_user
            // 
            this.lbl_form_user.AutoSize = true;
            this.lbl_form_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_form_user.Location = new System.Drawing.Point(87, 11);
            this.lbl_form_user.Name = "lbl_form_user";
            this.lbl_form_user.Size = new System.Drawing.Size(0, 18);
            this.lbl_form_user.TabIndex = 2;
            // 
            // btn_back_page
            // 
            this.btn_back_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back_page.Location = new System.Drawing.Point(653, 33);
            this.btn_back_page.Name = "btn_back_page";
            this.btn_back_page.Size = new System.Drawing.Size(103, 26);
            this.btn_back_page.TabIndex = 3;
            this.btn_back_page.Text = "Geriyə";
            this.btn_back_page.UseVisualStyleBackColor = true;
            this.btn_back_page.Click += new System.EventHandler(this.btn_back_page_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 600);
            this.Controls.Add(this.btn_back_page);
            this.Controls.Add(this.lbl_form_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productBox);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductDetails_FormClosed);
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox productBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back_page;
        public System.Windows.Forms.Label lbl_form_user;
    }
}