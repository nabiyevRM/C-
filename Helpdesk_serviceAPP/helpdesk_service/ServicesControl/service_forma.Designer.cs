namespace helpdesk_service.ServicesControl
{
    partial class Service_forma
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
            this.lbl_service_name = new System.Windows.Forms.Label();
            this.lbl_service_price = new System.Windows.Forms.Label();
            this.lbl_service_names = new System.Windows.Forms.Label();
            this.lbl_service_prices = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_service_name
            // 
            this.lbl_service_name.AutoSize = true;
            this.lbl_service_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_service_name.Location = new System.Drawing.Point(6, 15);
            this.lbl_service_name.Name = "lbl_service_name";
            this.lbl_service_name.Size = new System.Drawing.Size(0, 16);
            this.lbl_service_name.TabIndex = 0;
            // 
            // lbl_service_price
            // 
            this.lbl_service_price.AutoSize = true;
            this.lbl_service_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_price.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_service_price.Location = new System.Drawing.Point(313, 15);
            this.lbl_service_price.Name = "lbl_service_price";
            this.lbl_service_price.Size = new System.Drawing.Size(0, 16);
            this.lbl_service_price.TabIndex = 1;
            // 
            // lbl_service_names
            // 
            this.lbl_service_names.AutoSize = true;
            this.lbl_service_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_service_names.ForeColor = System.Drawing.Color.White;
            this.lbl_service_names.Location = new System.Drawing.Point(3, 17);
            this.lbl_service_names.Name = "lbl_service_names";
            this.lbl_service_names.Size = new System.Drawing.Size(0, 16);
            this.lbl_service_names.TabIndex = 2;
            // 
            // lbl_service_prices
            // 
            this.lbl_service_prices.AutoSize = true;
            this.lbl_service_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_service_prices.ForeColor = System.Drawing.Color.White;
            this.lbl_service_prices.Location = new System.Drawing.Point(313, 17);
            this.lbl_service_prices.Name = "lbl_service_prices";
            this.lbl_service_prices.Size = new System.Drawing.Size(0, 16);
            this.lbl_service_prices.TabIndex = 3;
            // 
            // Service_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lbl_service_prices);
            this.Controls.Add(this.lbl_service_names);
            this.Controls.Add(this.lbl_service_price);
            this.Controls.Add(this.lbl_service_name);
            this.Name = "Service_forma";
            this.Size = new System.Drawing.Size(677, 45);
            this.Load += new System.EventHandler(this.Service_forma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_service_name;
        private System.Windows.Forms.Label lbl_service_price;
        public System.Windows.Forms.Label lbl_service_names;
        public System.Windows.Forms.Label lbl_service_prices;
    }
}
