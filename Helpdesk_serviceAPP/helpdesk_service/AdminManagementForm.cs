using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using helpdesk_service.Models;
using helpdesk_service.Gui_Databases;

namespace helpdesk_service
{
    public partial class AdminManagementForm : Form
    {
        ArrayList month = new ArrayList();
        ArrayList years = new ArrayList();
        ArrayList days = new ArrayList();
      
        public AdminManagementForm()
        {
            InitializeComponent();
            // adding month to monthes list //
            month.Add("Yanvar");
            month.Add("Fevral");
            month.Add("Mart");
            month.Add("Aprel");
            month.Add("May");
            month.Add("Iyun");
            month.Add("Iyul");
            month.Add("Avqust");
            month.Add("Sentyabr");
            month.Add("Oktyabr");
            month.Add("Noyabr");
            month.Add("Dekabr");
            month_list.DataSource = month;

            // adding year to years list //
            years.Add(2019);
            years.Add(2020);
            years.Add(2021);
            years.Add(2022);
            years_list.DataSource = years;

            // adding day to days list //
            for (int i = 1; i <= 31; i++)
            {
                days.Add(i);
            }
            days_list.DataSource = days;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenerateCardsForSale generate_card_form = new GenerateCardsForSale();
            generate_card_form.Show();
            Visible = false;
        }

        private void AdminManagementForm_Load(object sender, EventArgs e)
        {
            // adding card details form userDB to admin managment form //
            ArrayList userData = UserDatabase.GetAllUsersData();
            foreach (UserModel user in userData)
            {
                lbl_when_used_date.Text = Convert.ToString(user.CardUsedTime);

                if(user.Name == null)
                {
                    lbl_card_user.Text = user.Email;
                }
                else
                {
                    lbl_card_user.Text = user.Name;
                }  
            }

            // adding card details form cardDB to admin managment form //
            ArrayList cardData = CardDetailsDB.GetAllCardData();
            foreach (CardModel card in cardData)
            {
                lbl_card_create_time.Text = Convert.ToString(card.CardCreate);
                lbl_expary_date.Text = Convert.ToString(card.CardExpiryDate);
                lbl_card_price.Text = card.CardPrice;
                lbl_card_number.Text = card.CardNumber;
            }

            // hide edit section when form loads //
            month_list.Visible = false;
            years_list.Visible = false;
            lbl_edit_name.Visible = false;
            btn_edit_submit.Visible = false;
            days_list.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // remove user from database //
            ArrayList cardData = CardDetailsDB.GetAllCardData();
            ArrayList userData = UserDatabase.GetAllUsersData();
            cardData.Clear();
            userData.Clear();

            // clearing data from labels //
            lbl_when_used_date.Text = "";
            lbl_card_user.Text = "";
            lbl_card_create_time.Text = "";
            lbl_expary_date.Text = "";
            lbl_card_price.Text = "";
            lbl_card_number.Text = "";
        }

        private void edit_user_data_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // show edit section //
            month_list.Visible = true;
            years_list.Visible = true;
            lbl_edit_name.Visible = true;
            btn_edit_submit.Visible = true;
            days_list.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get values from date list for update expiry date //
            string month = Convert.ToString(month_list.SelectedValue);
            int year = Convert.ToInt32(years_list.SelectedValue);
            int day = Convert.ToInt32(days_list.SelectedValue);
            var monthValue = 0;

            foreach (var monthes in Enum.GetNames(typeof(Months)))
            {
                if(month == monthes)
                {
                    monthValue = (byte)Enum.Parse(typeof(Months), monthes);
                }
            }

            // updated date method and set it to card details expiry date //
            DateTime updatedDate = new DateTime(year, monthValue, day);
            MessageBox.Show("Kartın müddəti " + updatedDate.ToString() + " zamana kimi uzadıldı");
            lbl_expary_date.Text = Convert.ToString(updatedDate);
            
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServicesListForm services_list_form = new ServicesListForm();
            services_list_form.Show();
            Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HelpdeskServiceForm helpdesk_form = new HelpdeskServiceForm();
            helpdesk_form.Show();
            Visible = false;
        }
    }
}
