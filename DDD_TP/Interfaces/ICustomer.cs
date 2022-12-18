namespace DDD_TP
{
    public interface ICustomer
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        public string PaymentMethod { get; set; }
        string CreateOrder();
    }
}