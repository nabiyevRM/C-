using Admin_Form;
using Admin_Form.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAe_App.Forms
{
    public partial class FormCover : Form
    {
        public FormCover()
        {
            InitializeComponent();
        }

        private void FormCover_Load(object sender, EventArgs e)
        {
            // get form information text from text file and writeing it to richtextbox //
            //string coverTxtPath = Environment.CurrentDirectory + "/form_cover" + "/cover.txt";
            //byte[] txt = File.ReadAllBytes(coverTxtPath);
            //form_cover_texbox.Text = Encoding.UTF8.GetString(txt);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginAdminForm log_admin = new LoginAdminForm();
            log_admin.Show();
            this.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StickersForm stickers = new StickersForm();
            stickers.Show();
            this.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void FormCover_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
