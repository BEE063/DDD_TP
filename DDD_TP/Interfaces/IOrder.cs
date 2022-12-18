using System.Collections.Generic;

namespace DDD_TP.Interfaces
{
    public interface IOrder
    {
        public int Id { get; set; }
        public string OrderStatus  { get; set; }
        public string Address  { get; set; }
        public IList<string> ProductList  { get; set; }
        string Deliver();
    }
}