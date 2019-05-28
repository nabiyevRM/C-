using Admin_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Form.Forms
{
    public partial class LoginAdminForm : Form
    {
        public LoginAdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txbx_admin_email.Text == Admin.Admin_Email && txbx_admin_password.Text == Admin.Admin_Password)
            {
                MessageBox.Show("Sistemə uğurlu daxil oldunuz.");
                Form1 admin_form = new Form1();
                admin_form.Show();
                this.Visible = false;
            }
        }

        private void LoginAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
