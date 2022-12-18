using System.Collections.Generic;

namespace DDD_TP.Interfaces
{
    public interface IOrderFactory
    {
        ICustomer CreateCustomer(int id, string cardType, string paymentMethod);
        IOrder CreateOrder(int id, string orderStatus, string address, IList<string> productLis);
    }
}