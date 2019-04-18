using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AistGroup_IT_Company.Models;
using AistGroup_IT_Company.Gui;

namespace AistGroup_IT_Company.Controls
{
    public partial class Vacancies : UserControl
    {
        public Vacancies()
        {
            InitializeComponent();
        }

        private void Vacancies_Load(object sender, EventArgs e)
        {   
            //load vacancies to vacancy form//

            txbx_cv_format.Visible = false;
            ArrayList users = UserDB.GetAllData();
            foreach(User user in users)
            {
                //adding user datas dynmaic to cv if user accepts any vacancy//
                txbx_cv_name.Text = user.Name;
                txbx_cv_surname.Text = user.Surname;
                txbx_cv_email.Text = user.Email;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbx_cv_format.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txbx_cv_format.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adding cv data to cv class//
            CV_Format cv_format = new CV_Format();
            cv_format.CV_User_Name = txbx_cv_name.Text;
            cv_format.CV_User_Surname = txbx_cv_surname.Text;
            cv_format.CV_User_Email = txbx_cv_email.Text;
            cv_format.CV_User_Skills = txbx_cv_skills.Text;
            cv_format.CV_User_Salary = txbx_cv_salary.Text;

            //checking cv texbox inputs data//
            Validator validator = new Validator();
            if (validator.cvChecking(cv_format))
            {
                //sending cv to company if doesn't has any error//
                string[] cv_errors = validator.GetAllCVerrorsArray();
                if(cv_errors.Length == 0)
                {
                    CV_DB.AddCV(cv_format);
                    MessageBox.Show("CV uğurla göndərildi"+"\n" +"Yuxarıdakı seansı bitir bölməsinə click edərək sistemi bağlamalısınız");
                }
                else
                {
                    MessageBox.Show("CV tamamlanmamışdır zəhmət olmasa bütün bölmələri doldurun");
                }
            }
        }
    }
}
