using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AistGroup_IT_Company.Controls;
using AistGroup_IT_Company.Models;
using AistGroup_IT_Company.Gui;

namespace AistGroup_IT_Company
{
    public partial class CompanyVacanciesForm : Form
    {
        public CompanyVacanciesForm()
        {
            InitializeComponent();
        }

        private void CompanyVacanciesForm_Load(object sender, EventArgs e)
        {
            Vacancies vacancy = new Vacancies();
            vacancy.Location = new Point(3, 15);
            vacacies_content.Controls.Add(vacancy);
            ArrayList users = UserDB.GetAllData();
            foreach (User user in users)
            {
                form_current_user.Text = user.Name + " " + user.Surname;
            }
        }

        private void vacacies_content_Enter(object sender, EventArgs e)
        {

        }

        private void CompanyVacanciesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CompanyAdminForm comp_adm_form = new CompanyAdminForm();
            comp_adm_form.Show();
            this.Hide();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            CompanyAdminForm comp_adm_form = new CompanyAdminForm();
            comp_adm_form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList responseFromCompany = Response_CV_DB.GetAllData();
            foreach (Response_CV_Class response in responseFromCompany)
            {
                if(response.Reject == null)
                {
                    MessageBox.Show(response.Accept);
                }
                else if(response.Accept == null)
                {
                    MessageBox.Show(response.Reject);
                } 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
