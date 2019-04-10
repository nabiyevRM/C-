using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AistGroup_IT_Company.Gui;
using AistGroup_IT_Company.Controls;
using AistGroup_IT_Company.Models;

namespace AistGroup_IT_Company
{
    public partial class Whatching_CV_Form : Form
    {
        public Whatching_CV_Form()
        {
            InitializeComponent();
        }

        private void Whatching_CV_Form_Load(object sender, EventArgs e)
        {
            Visible = false;
            CV_format cv_control = new CV_format();
            cv_control.Location = new Point(14, 20);
            cv_content.Controls.Add(cv_control);

            ArrayList cv_data = CV_DB.GetAllData();
            foreach (CV_Format cv in cv_data)
            {
                cv_control.txbx_loadcv_name.Text = cv.CV_User_Name;
                cv_control.txbx_loadcv_surname.Text = cv.CV_User_Surname;
                cv_control.txbx_loadcv_email.Text = cv.CV_User_Email;
                cv_control.txbx_loadcv_skills.Text = cv.CV_User_Skills;
                cv_control.txbx_loadcv_salary.Text = cv.CV_User_Salary;
            }
            
        }

        private void cv_content_Enter(object sender, EventArgs e)
        {
           
        }

        internal void FormClosed()
        {
            throw new NotImplementedException();
        }
    }
}
