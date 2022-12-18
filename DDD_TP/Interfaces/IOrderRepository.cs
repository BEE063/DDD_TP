namespace DDD_TP.Interfaces
{
    public interface IOrderRepository
    {
        void Add(IOrder order);
        IOrder GetOrderById(int id);
    }
}