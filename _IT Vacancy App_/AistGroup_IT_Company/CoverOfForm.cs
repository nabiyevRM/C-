using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AistGroup_IT_Company
{
    public partial class CoverOfForm : Form
    {
        public CoverOfForm()
        {
            InitializeComponent();
        }

        private void CoverOfForm_Load(object sender, EventArgs e)
        {

        }

        private void reg_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationAndLoginForm reg_login_form = new RegistrationAndLoginForm();
            reg_login_form.Show();
            Visible = false;
        }
    }
}
