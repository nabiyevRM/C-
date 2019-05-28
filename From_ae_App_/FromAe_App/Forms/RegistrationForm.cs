using Admin_Form.Models;
using FromAe_App.Models;
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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void txbx_reg_btn_Click(object sender, EventArgs e)
        {
            // adding user information to database from registration form //
            UsingDB usingDB = new UsingDB();
            usingDB.ConnectDB("FromAeDB");
            string values = $"'{txbx_reg_name.Text}','{txbx_reg_surname.Text}','{txbx_reg_email.Text}','{txbx_reg_password.Text}'";
            usingDB.InsertToDB("Users", values);
            usingDB.DisposeSeans();
            MessageBox.Show("Qeydiyyatınız uğurla yekulnaşdı" + "\n" + "Zəhmət olmasa sistemə daxil olun.");
        }

        private void txbx_log_btn_Click(object sender, EventArgs e)
        {
            // checking user details for login //
            UsingDB usingDB = new UsingDB();
            List<UserModel> users = usingDB.GetUser("FromAeDB");
            usingDB.DisposeSeans();
            bool check = false;
            foreach (var user in users)
            {
                if(user.Email == txbx_log_email.Text && user.Password == txbx_log_password.Text)
                {
                    check = true;
                    Form_User.UserId = Convert.ToInt32(user.UserId);
                    Form_User.Name = user.Name;
                    Form_User.Surname = user.Surname;
                    break;
                }
                else
                {
                    check = false;
                }
            };
            if(check == true)
            {
                MessageBox.Show("Sistemə daxil oldunuz.");
                ProductDetails pro_details = new ProductDetails();
                pro_details.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Email yaxud şifrə yanlışdır.");

        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
