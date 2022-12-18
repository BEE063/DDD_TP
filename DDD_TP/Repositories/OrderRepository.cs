using System.Collections.Generic;
using DDD_TP.Interfaces;

namespace DDD_TP.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private List<IOrder> _ordersCollection = new List<IOrder>();

        public void Add(IOrder order)
        {
            _ordersCollection.Add(order);
        }

        public IOrder GetOrderById(int id)
        {
            return _ordersCollection.Find(x => x.Id == id);
        }
    }
}