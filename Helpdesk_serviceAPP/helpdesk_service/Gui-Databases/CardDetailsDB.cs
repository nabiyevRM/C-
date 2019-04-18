using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helpdesk_service.Models;

namespace helpdesk_service.Gui_Databases
{
    static class CardDetailsDB
    {
        private static ArrayList cardDetails = new ArrayList();

        public static ArrayList AddingCard(CardModel cardModel)
        {
            cardDetails.Add(cardModel);
            return cardDetails;
        }

        public static ArrayList GetAllCardData()
        {
            return cardDetails;
        }
    }
}
