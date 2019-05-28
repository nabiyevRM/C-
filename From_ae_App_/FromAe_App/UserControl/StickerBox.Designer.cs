namespace Admin_Form
{
    partial class StickerBox
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
            this.stickerPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.lbl_product_price = new System.Windows.Forms.Label();
            this.btn_read_more = new System.Windows.Forms.Button();
            this.product_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stickerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // stickerPhoto
            // 
            this.stickerPhoto.Location = new System.Drawing.Point(0, 0);
            this.stickerPhoto.Name = "stickerPhoto";
            this.stickerPhoto.Size = new System.Drawing.Size(158, 151);
            this.stickerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stickerPhoto.TabIndex = 0;
            this.stickerPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qiyməti:";
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_product_name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_product_name.Location = new System.Drawing.Point(56, 156);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(0, 16);
            this.lbl_product_name.TabIndex = 3;
            // 
            // lbl_product_price
            // 
            this.lbl_product_price.AutoSize = true;
            this.lbl_product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_product_price.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_product_price.Location = new System.Drawing.Point(56, 177);
            this.lbl_product_price.Name = "lbl_product_price";
            this.lbl_product_price.Size = new System.Drawing.Size(0, 16);
            this.lbl_product_price.TabIndex = 4;
            // 
            // btn_read_more
            // 
            this.btn_read_more.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_read_more.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_read_more.Location = new System.Drawing.Point(39, 196);
            this.btn_read_more.Name = "btn_read_more";
            this.btn_read_more.Size = new System.Drawing.Size(68, 23);
            this.btn_read_more.TabIndex = 5;
            this.btn_read_more.Text = "Ətrafı bax";
            this.btn_read_more.UseVisualStyleBackColor = true;
            this.btn_read_more.Click += new System.EventHandler(this.btn_read_more_Click);
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.Location = new System.Drawing.Point(3, 211);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(0, 13);
            this.product_id.TabIndex = 6;
            // 
            // StickerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.btn_read_more);
            this.Controls.Add(this.lbl_product_price);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stickerPhoto);
            this.Name = "StickerBox";
            this.Size = new System.Drawing.Size(159, 218);
            ((System.ComponentModel.ISupportInitialize)(this.stickerPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox stickerPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_product_name;
        public System.Windows.Forms.Label lbl_product_price;
        private System.Windows.Forms.Button btn_read_more;
        public System.Windows.Forms.Label product_id;
    }
}
