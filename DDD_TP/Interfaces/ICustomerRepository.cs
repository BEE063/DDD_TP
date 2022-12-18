namespace DDD_TP.Interfaces
{
    public interface ICustomerRepository
    {
        void Add(ICustomer customer);
        ICustomer GetCustomerById(int id);
    }
}