namespace helpdesk_service
{
    partial class GenerateCardsForSale
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_generated_card_number = new System.Windows.Forms.TextBox();
            this.btn_create_card = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_card_price = new System.Windows.Forms.TextBox();
            this.btn_saleCard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satışa çıxarılacaq kartların hazırlanması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart nömrəsi:";
            // 
            // txbx_generated_card_number
            // 
            this.txbx_generated_card_number.Location = new System.Drawing.Point(35, 92);
            this.txbx_generated_card_number.Name = "txbx_generated_card_number";
            this.txbx_generated_card_number.Size = new System.Drawing.Size(260, 20);
            this.txbx_generated_card_number.TabIndex = 2;
            // 
            // btn_create_card
            // 
            this.btn_create_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_card.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_create_card.Location = new System.Drawing.Point(320, 89);
            this.btn_create_card.Name = "btn_create_card";
            this.btn_create_card.Size = new System.Drawing.Size(112, 24);
            this.btn_create_card.TabIndex = 3;
            this.btn_create_card.Text = "Kart yarat";
            this.btn_create_card.UseVisualStyleBackColor = true;
            this.btn_create_card.Click += new System.EventHandler(this.btn_create_card_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(32, 124);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kartın qiyməti:";
            // 
            // txbx_card_price
            // 
            this.txbx_card_price.Location = new System.Drawing.Point(35, 149);
            this.txbx_card_price.Name = "txbx_card_price";
            this.txbx_card_price.Size = new System.Drawing.Size(94, 20);
            this.txbx_card_price.TabIndex = 5;
            // 
            // btn_saleCard
            // 
            this.btn_saleCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saleCard.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_saleCard.Location = new System.Drawing.Point(96, 196);
            this.btn_saleCard.Name = "btn_saleCard";
            this.btn_saleCard.Size = new System.Drawing.Size(102, 30);
            this.btn_saleCard.TabIndex = 6;
            this.btn_saleCard.Text = "Satışa çıxart";
            this.btn_saleCard.UseVisualStyleBackColor = true;
            this.btn_saleCard.Click += new System.EventHandler(this.btn_saleCard_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seansı bitir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenerateCardsForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_saleCard);
            this.Controls.Add(this.txbx_card_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_create_card);
            this.Controls.Add(this.txbx_generated_card_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenerateCardsForSale";
            this.Text = "Kartın hazırlanması və satışa çıxarılması formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_generated_card_number;
        private System.Windows.Forms.Button btn_create_card;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_card_price;
        private System.Windows.Forms.Button btn_saleCard;
        private System.Windows.Forms.Button button1;
    }
}