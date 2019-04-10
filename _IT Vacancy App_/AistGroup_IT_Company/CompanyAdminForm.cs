using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AistGroup_IT_Company.Gui;
using AistGroup_IT_Company.Models;

namespace AistGroup_IT_Company
{
    public partial class CompanyAdminForm : Form
    {
        public CompanyAdminForm()
        {
            InitializeComponent();
            //Admin_user_data.initAdminData();
        }

        private void CompanyAdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company_admin_user admin_user = new Company_admin_user();
            if (admin_user.Admin_Email == txbx_admin_email.Text && admin_user.Admin_Password == txbx_admin_password.Text)
            {
                Whatching_CV_Form whatch_cv = new Whatching_CV_Form();
                whatch_cv.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Email yaxud şifrə yanlışdır");
            }
        }
    }
}
