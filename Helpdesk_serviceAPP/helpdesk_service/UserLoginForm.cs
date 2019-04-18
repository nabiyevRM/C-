using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helpdesk_service.Models;
using helpdesk_service.Gui_Databases;

namespace helpdesk_service
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking email and password user to enter service form//
            ArrayList users = UserDatabase.GetAllUsersData();
            foreach (UserModel user in users)
            {
                if(user.Email == txbx_user_email.Text && user.Password == txbx_user_password.Text)
                {
                    MessageBox.Show("Sistemə uğurlu daxil olduz");
                    HelpdeskServiceForm h_services_form = new HelpdeskServiceForm();
                    h_services_form.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Email yaxud şifrə yanlışdır.");
                }
            }
        }
    }
}
