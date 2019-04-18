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
using helpdesk_service.Validation;
using helpdesk_service.Gui_Databases;

namespace helpdesk_service
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CompanyAdminForm comp_admin_form = new CompanyAdminForm();
            comp_admin_form.Show();
            Visible = false;
        }

        private void btn_reg_without_card_Click(object sender, EventArgs e)
        {
            lbl_errors.Text = "";
            // writeing reg user details to simple_user class//

            SimpleUser simple_user = new SimpleUser();
            simple_user.Name = txbx_reg_name.Text;
            simple_user.Surname = txbx_reg_surname.Text;
            simple_user.Email = txbx_reg_email.Text;
            simple_user.Password = txbx_reg_password.Text;
            simple_user.Confirm_Password = txbx_reg_confirm_password.Text;

            // checking simple user texboxs if doesn't contain error user will be add to user database//

            SimpleUserValidator simpleUser_val = new SimpleUserValidator();
            if (simpleUser_val.CheckInputs(simple_user))
            {
                string[] errors = simpleUser_val.GetAllErrorArray();
                foreach (string error in errors)
                {
                    lbl_errors.Text += error + "\n";
                }
                if(errors.Length == 0)
                {
                    MessageBox.Show("Qeydiyyatınız uğurlu yekunlaşdı." + "\n" + "Zəhmət olmasa sistemə daxil olun.");
                    UserDatabase.AddUser(simple_user);
                    UserLoginForm user_login_form = new UserLoginForm();
                    user_login_form.Show();
                    Visible = false;
                }
            }
        }

        private void btn_reg_with_card_Click(object sender, EventArgs e)
        {
            lbl_errors.Text = "";
            // writeing reg user details to simple_user class//

            CardUser card_user = new CardUser();
            card_user.Card_Number = txbx_regWithCard_cardNumber.Text;
            card_user.Email = txbx_regWithCard_email.Text;
            card_user.Password = txbx_regWithCard_password.Text;
            card_user.Confirm_Password = txbx_regWithCard_confirm_password.Text;
            card_user.CardUsedTime = DateTime.Now;

            // checking simple user texboxs if doesn't contain error user will be add to user database //

            CardUserValidator cardUser_val = new CardUserValidator();

            if (cardUser_val.CheckInputs(card_user))
            {
                string[] errors = cardUser_val.GetAllErrorArray();
                foreach (string error in errors)
                {
                    lbl_errors.Text += error + "\n";
                }
                if (errors.Length == 0)
                {
                    MessageBox.Show("Qeydiyyatınız uğurlu yekunlaşdı...");
                    UserDatabase.AddUser(card_user);
                    UserLoginForm user_login_form = new UserLoginForm();
                    user_login_form.Show();
                    Visible = false;
                }
            }

        }
    }
}
