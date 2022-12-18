using System.Collections.Generic;
using DDD_TP.Entities;
using DDD_TP.Interfaces;

namespace DDD_TP.Factories
{
    public class VipOrderFactory: IOrderFactory
    {
        public ICustomer CreateCustomer(int id, string cardType, string paymentMethod)
        {
            return new VipCustomer(id, cardType, paymentMethod);
        }

        public IOrder CreateOrder(int id, string orderStatus, string address, IList<string> productList)
        {
            return new FastDeliveryOrder(id, orderStatus, address, productList);
        }
    }
}