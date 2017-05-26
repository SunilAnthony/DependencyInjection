using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class LoggingOrderDB : IOrderSaver
    {
        public void DeleteOrder(int id)
        {
            Console.WriteLine("The following order will be DELETE the LoggingOrderDB, Id : {0}, ProductNumber : {1}, Product Description : {2} ", "1", "PLU52254", "Log DB Mango");
            Console.ReadLine();
        }

        public void SaveOrder(Order order)
        {
            Console.WriteLine("The following order will be SAVE the LoggingOrderDB, Id : {0}, ProductNumber : {1}, Product Description : {2} ", order.Id, order.ProductNumber, order.ProductDescription);
            Console.ReadLine();
        }

        public void UpdateOrder(int id)
        {
            Console.WriteLine("The following order will be UPDATE the LoggingOrderDB, Id : {0}, ProductNumber : {1}, Product Description : {2} ", "1", "PLU52254", "Log DB Mango");
            Console.ReadLine();
        }

        public Order ViewOrder(int id)
        {
            Order two = new Order();
            two.Id = 2;
            two.ProductNumber = "PLU32323";
            two.ProductDescription = "This is a LogDB manago";
            return two;
        }

        public List<Order> ViewOrders(string product)
        {
            List<Order> list = new List<Order>();
            Order One = new Order();
            One.Id = 1;
            One.ProductNumber = "PLU32123";
            One.ProductDescription = "This is a Log DB manago";
            list.Add(One);
            Order two = new Order();
            two.Id = 2;
            two.ProductNumber = "PLU32323";
            two.ProductDescription = "This is a LogDB manago";
            list.Add(two);
            return list;
        }
    }
}
