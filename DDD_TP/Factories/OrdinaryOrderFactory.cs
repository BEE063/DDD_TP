using System.Collections.Generic;
using DDD_TP.Entities;
using DDD_TP.Interfaces;

namespace DDD_TP.Factories
{
    public class OrdinaryOrderFactory: IOrderFactory
    {
        public ICustomer CreateCustomer(int id, string cardType, string paymentMethod)
        {
            return new OrdinaryCustomer(id, cardType, paymentMethod);
        }

        public IOrder CreateOrder(int id, string orderStatus, string address, IList<string> productLis)
        {
            return new OrdinaryOrder(id, orderStatus, address, productLis);
        }
    }
}