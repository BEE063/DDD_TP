using DDD_TP.Interfaces;

namespace DDD_TP.Factories
{
    public class OrderFactory
    {
        public static IOrderFactory Create(string orderType)
        {
            switch (orderType)
            {
                case "Ordinary":
                    return new OrdinaryOrderFactory();
                case "Vip":
                    return new VipOrderFactory();
            }
            
            return null;
        }
    }
}