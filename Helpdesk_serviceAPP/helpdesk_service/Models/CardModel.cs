using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpdesk_service.Models
{
    class CardModel
    {
        private string cardNumber;
        private string cardPrice;
        private DateTime cardCreate;
        private DateTime cardExpiryData;

        public string CardNumber { get { return cardNumber; } set { cardNumber = value; } }
        public string CardPrice { get { return cardPrice; } set { cardPrice = value; } }
        public DateTime CardCreate { get { return cardCreate; } set { cardCreate = value; } }
        public DateTime CardExpiryDate { get { return cardExpiryData; } set { cardExpiryData = value; } }
    }
}
