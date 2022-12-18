using System.Collections.Generic;
using DDD_TP.Interfaces;

namespace DDD_TP.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private List<ICustomer> _customersCollection = new List<ICustomer>();

        public void Add(ICustomer customer)
        {
            _customersCollection.Add(customer);
        }

        public ICustomer GetCustomerById(int id)
        {
            return _customersCollection.Find(x => x.Id == id);
        }

    }
}