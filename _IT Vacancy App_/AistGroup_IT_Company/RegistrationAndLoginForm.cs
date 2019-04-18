using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AistGroup_IT_Company.Models;
using AistGroup_IT_Company.Gui;

namespace AistGroup_IT_Company
{
    public partial class RegistrationAndLoginForm : Form
    {
        public RegistrationAndLoginForm()
        {
            InitializeComponent();
        }

        private void txbx_reg_btn_Click(object sender, EventArgs e)
        {
            show_errors.Text = "";

            //adding input information to user class//
            User user = new User();
            user.Name = txbx_reg_name.Text;
            user.Surname = txbx_reg_surname.Text;
            user.Email = txbx_reg_email.Text;
            user.Password = txbx_reg_password.Text;
            user.Confirm_Password = txbx_reg_confirmPassword.Text;

            //validation textbox//
            Validator validator = new Validator();
            if (validator.CheckInputs(user))
            {
                string[] errors = validator.GetAllErrorArray();
                foreach(string error in errors)
                {
                    show_errors.Text += error + "\n";
                }
                //adding user to UserDB if errors doesn't has in erros array//
                if(errors.Length == 0)
                {
                    MessageBox.Show("Qeydiyyatınız uğurlu yekunlaşdı...");
                    UserDB.AddUser(user);
                }
            }
        }

        private void txbx_log_btn_Click(object sender, EventArgs e)
        {
            //adding input information to Login_User class//
            Login_User log_user = new Login_User();
            log_user.Login_Email = txbx_log_email.Text;
            log_user.Login_Password = txbx_log_password.Text;

            ArrayList users = UserDB.GetAllData();
            foreach (User user in users)
            {
                //checking txbx_inputs information have in Login_User database//
                if (user.Email == txbx_log_email.Text && user.Password == txbx_log_password.Text)
                {
                    MessageBox.Show("Sistemə uğurlu daxil oldunuz");
                    CompanyVacanciesForm comVacForm = new CompanyVacanciesForm();
                    comVacForm.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Elektron poçt ünvanız yaxud şifrəniz yanlışdır");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegistrationAndLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
