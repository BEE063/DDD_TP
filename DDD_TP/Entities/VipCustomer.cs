namespace DDD_TP.Entities
{
    public class VipCustomer: ICustomer
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        public string PaymentMethod { get; set; }
        private int Discount = 10;
        
        public VipCustomer(int id, string cardType, string paymentMethod)
        {
            this.Id = id;
            this.CardType = cardType;
            this.PaymentMethod = paymentMethod;
        }

        public string CreateOrder()
        {
            return "Order № " + Id + " created. Your personal discount: " + Discount + ".";
        }
    }
}