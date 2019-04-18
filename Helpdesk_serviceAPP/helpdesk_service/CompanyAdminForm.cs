using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helpdesk_service.Models;

namespace helpdesk_service
{
    public partial class CompanyAdminForm : Form
    {
        public CompanyAdminForm()
        {
            InitializeComponent();
        }

        private void CompanyAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking login to enter card generate form//
            if(AdminUser.AdminEmail.ToString() == txbx_admin_email.Text && AdminUser.AdminPassword.ToString() == txbx_admin_password.Text)
            {
                AdminManagementForm admin_manage_form = new AdminManagementForm();
                MessageBox.Show("Sistemə uğurlu daxil olduz");
                admin_manage_form.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Email yaxud şifrə yanlışdır");
            }
           
        }
    }
}
