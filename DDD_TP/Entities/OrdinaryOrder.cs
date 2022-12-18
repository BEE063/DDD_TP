using System.Collections.Generic;
using DDD_TP.Interfaces;

namespace DDD_TP.Entities
{
    public class OrdinaryOrder: IOrder
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public string Address { get; set; }
        public IList<string> ProductList { get; set; }

        public OrdinaryOrder(int id, string orderStatus, string address, IList<string> productList)
        {
            this.Id = id;
            this.OrderStatus = orderStatus;
            this.Address = address;
            this.ProductList = productList;
        }

        public string Deliver()
        {
            return "Your order in " + OrderStatus + ". Within two days your order will be delivered to " + Address + ".";
        }
    }
}