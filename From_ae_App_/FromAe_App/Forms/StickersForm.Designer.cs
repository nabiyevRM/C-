namespace Admin_Form.Forms
{
    partial class StickersForm
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
            this.stickersBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_close_form = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stickersBox
            // 
            this.stickersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stickersBox.ForeColor = System.Drawing.Color.Crimson;
            this.stickersBox.Location = new System.Drawing.Point(12, 32);
            this.stickersBox.Name = "stickersBox";
            this.stickersBox.Size = new System.Drawing.Size(578, 613);
            this.stickersBox.TabIndex = 0;
            this.stickersBox.TabStop = false;
            this.stickersBox.Text = "Elanlar";
            this.stickersBox.Enter += new System.EventHandler(this.stickersBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satışdakı mallar";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_back.Location = new System.Drawing.Point(425, 651);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 29);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Geriye";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_next.Location = new System.Drawing.Point(502, 651);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 29);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "İrəli";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_close_form
            // 
            this.btn_close_form.Location = new System.Drawing.Point(443, 6);
            this.btn_close_form.Name = "btn_close_form";
            this.btn_close_form.Size = new System.Drawing.Size(75, 23);
            this.btn_close_form.TabIndex = 3;
            this.btn_close_form.UseVisualStyleBackColor = true;
            this.btn_close_form.Click += new System.EventHandler(this.btn_close_form_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 6);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Geriyə";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // StickersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 692);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btn_close_form);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.stickersBox);
            this.Name = "StickersForm";
            this.Text = "StickersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StickersForm_FormClosed);
            this.Load += new System.EventHandler(this.StickersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox stickersBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_close_form;
        private System.Windows.Forms.Button back_btn;
    }
}