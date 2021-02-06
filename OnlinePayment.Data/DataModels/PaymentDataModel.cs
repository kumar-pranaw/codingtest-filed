using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePayment.Data.DataModels
{
    public class PaymentDataModel
    {
        public int Id { get; set; }
        public string CreditCardNumber { get; set; }
        public string CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
        public double Amount { get; set; }
    }
}
