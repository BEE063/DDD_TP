using DDD_TP.Interfaces;

namespace DDD_TP.Entities
{
    public class OrdinaryCustomer: ICustomer
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        public string PaymentMethod { get; set; }

        public OrdinaryCustomer(int id, string cardType, string paymentMethod)
        {
            this.Id = id;
            this.CardType = cardType;
            this.PaymentMethod = paymentMethod;
        }

        public string CreateOrder()
        {
            return "Order № " + Id + " created.";
        }
    }
}