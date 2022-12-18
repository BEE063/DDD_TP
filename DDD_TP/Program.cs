using System;
using System.Collections.Generic;
using DDD_TP.Factories;
using DDD_TP.Interfaces;
using DDD_TP.Repositories;

namespace DDD_TP
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderFactory ordinaryFactory = OrderFactory.Create("Ordinary");
            IOrderFactory vipFactory = OrderFactory.Create("Vip");
            ICustomerRepository customerRepository = new CustomerRepository();
            IOrderRepository orderRepository = new OrderRepository();
            
            customerRepository.Add(ordinaryFactory.CreateCustomer(1, "VISA","Debit"));
            orderRepository.Add(ordinaryFactory.CreateOrder(1, "stock", "Moscow",new List<string>()));
            
            customerRepository.Add(vipFactory.CreateCustomer(2, "MIR","Credit"));
            orderRepository.Add(vipFactory.CreateOrder(2, "delivery", "Moscow",new List<string>()));

            ICustomer ordinaryCustomer = customerRepository.GetCustomerById(1);
            IOrder ordinaryOrder = orderRepository.GetOrderById(1);
            
            Console.WriteLine("Ordinary Customer: " + ordinaryCustomer.CreateOrder());
            Console.WriteLine("Ordinary Order: " + ordinaryOrder.Deliver());
            
            ICustomer vipCustomer = customerRepository.GetCustomerById(2);
            IOrder vipOrder = orderRepository.GetOrderById(2);
            
            Console.WriteLine("VIP Customer: " + vipCustomer.CreateOrder());
            Console.WriteLine("VIP Order: " + vipOrder.Deliver());
        }
    }
}