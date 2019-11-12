using System;
namespace MyDimDim.Models
{
    public class CreditCard
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public decimal BillValue { get; set; }
        public DateTime Expiration { get; set; }
        public string CardColor { get; set; }
        public string TextColor { get; set; }
    }
}
