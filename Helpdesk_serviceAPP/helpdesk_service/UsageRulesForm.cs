using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helpdesk_service
{
    public partial class UsageRulesForm : Form
    {
        public UsageRulesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegistrationForm user_reg = new UserRegistrationForm();
            user_reg.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompanyAdminForm admin_form = new CompanyAdminForm();
            admin_form.Show();
            Visible = false;
        }
    }
}
