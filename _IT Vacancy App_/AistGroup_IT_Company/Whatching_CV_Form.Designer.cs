namespace AistGroup_IT_Company
{
    partial class Whatching_CV_Form
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
            this.cv_content = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cv_content
            // 
            this.cv_content.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cv_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cv_content.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cv_content.Location = new System.Drawing.Point(12, 12);
            this.cv_content.Name = "cv_content";
            this.cv_content.Size = new System.Drawing.Size(513, 384);
            this.cv_content.TabIndex = 0;
            this.cv_content.TabStop = false;
            this.cv_content.Text = "Daxil olan cvlər";
            this.cv_content.Enter += new System.EventHandler(this.cv_content_Enter);
            // 
            // Whatching_CV_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 408);
            this.Controls.Add(this.cv_content);
            this.Name = "Whatching_CV_Form";
            this.Text = "Whatching_CV_Form";
            this.Load += new System.EventHandler(this.Whatching_CV_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cv_content;
    }
}