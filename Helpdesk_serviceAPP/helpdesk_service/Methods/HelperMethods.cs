using helpdesk_service.Gui_Databases;
using helpdesk_service.Models;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpdesk_service.Methods
{
    class HelperMethods
    {
        // bring service price from selected helpdesk service // 
        private ArrayList services = ServicesDB.GetAllServices();
        private string servicePrice = "";

        public int GetServicePrice(string txbxValue)
        {
            foreach (Services_Model prices in services)
            {
                if (prices.Service_ID == txbxValue)
                {
                    foreach (char item in prices.Service_Price)
                    {
                        if (item >= 48 && item <= 57)
                        {
                            servicePrice += item;
                        }
                    }
                }
            }
            int price = Convert.ToInt32(servicePrice);
            return price;
        }

        // get current balance from card details database // 
        private ArrayList currentPrices = CardDetailsDB.GetAllCardData();
        private string currentPriceConverted = "";

        public int GetCurrentBalance()
        {
            foreach (CardModel prices in currentPrices)
            {

                foreach (char item in prices.CardPrice)
                {
                    if (item >= 48 && item <= 57)
                    {
                        currentPriceConverted += item;
                    }
                }
            }
            int balance = Convert.ToInt32(currentPriceConverted);
            return balance;
        }
    }
}
