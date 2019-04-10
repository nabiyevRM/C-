using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AistGroup_IT_Company.Gui;
using AistGroup_IT_Company.Models;

namespace AistGroup_IT_Company.Controls
{
    public partial class CV_format : UserControl
    {
        public CV_format()
        {
            InitializeComponent();
        }

        private void CV_format_Load(object sender, EventArgs e)
        {
            txbx_reject_reason.Visible = false;
            lbl_reject.Visible = false;
            btn_reason_send.Visible = false;
            lbl_accept_reason.Visible = false;
            txbx_accept_reason.Visible = false;
            btn_accept_reason.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vacancies vacancy = new Vacancies();
            ArrayList cv_data = CV_DB.GetAllData();
            foreach (CV_Format cv in cv_data)
            {
                if (vacancy.lbl_vacancy_salary.Text == cv.CV_User_Salary && vacancy.lbl_vacancy_requirements.Text == cv.CV_User_Skills)
                {
                    cv_groupbox.BackColor = Color.MidnightBlue;
                    lbl_accept_reason.Visible = true;
                    txbx_accept_reason.Visible = true;
                    btn_accept_reason.Visible = true;
                }
                else if(vacancy.lbl_vacancy2_salary.Text == cv.CV_User_Salary && vacancy.lbl_vacancy2_requirements.Text == cv.CV_User_Skills)
                {
                    cv_groupbox.BackColor = Color.MidnightBlue;
                    lbl_accept_reason.Visible = true;
                    txbx_accept_reason.Visible = true;
                    btn_accept_reason.Visible = true;
                }
                else
                {
                    MessageBox.Show("CV şirkətimizin tələblərinə uyğun deyil,CV-ə imtina verməlisiniz");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbx_reject_reason.Visible = true;
            lbl_reject.Visible = true;
            btn_reason_send.Visible = true;
        }

        private void btn_accept_reason_Click(object sender, EventArgs e)
        {
            Response_CV_Class conversation = new Response_CV_Class();
            conversation.Accept = txbx_accept_reason.Text;
            Response_CV_DB.AddCVAcceptReason(conversation);
            Whatching_CV_Form w = new Whatching_CV_Form();
            RegistrationAndLoginForm log_form = new RegistrationAndLoginForm();
            log_form.Show();
        }

        private void btn_reason_send_Click(object sender, EventArgs e)
        {
            Response_CV_Class conversation = new Response_CV_Class();
            conversation.Reject = txbx_reject_reason.Text;
            Response_CV_DB.AddCVAcceptReason(conversation);
            RegistrationAndLoginForm log_form = new RegistrationAndLoginForm();
            log_form.Show();
        }
    }
}
