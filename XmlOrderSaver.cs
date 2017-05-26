using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class XmlOrderSaver : IOrderSaver
    {
       
        public void DeleteOrder(int id)
        {
            Console.WriteLine("The following order will be DELETE to XML, Id : {0}, ProductNumber : {1}, Product Description : {2}", "1", "PLU52254", "Xml Mango");
            Console.ReadLine();
        }

        public void SaveOrder(Order order)
        {
            Console.WriteLine("The following order will be SAVE to XML, Id : {0}, ProductNumber : {1}, Product Description : {2}", order.Id, order.ProductNumber, order.ProductDescription);
            Console.ReadLine();
        }

       
        public void UpdateOrder(int id)
        {
            Console.WriteLine("The following order will be UPDATE to XML, Id : {0}, ProductNumber : {1}, Product Description : {2}", "1", "PLU52254", "XML Mango");
            Console.ReadLine();
        }

        public Order ViewOrder(int id)
        {
            Order two = new Order();
            two.Id = 2;
            two.ProductNumber = "PLU32323";
            two.ProductDescription = "This is a XML manago";
            return two;
        }

        public List<Order> ViewOrders(string product)
        {
            List<Order> list = new List<Order>();
            Order One = new Order();
            One.Id = 1;
            One.ProductNumber = "PLU32123";
            One.ProductDescription = "This is a XML manago";
            list.Add(One);
            Order two = new Order();
            two.Id = 2;
            two.ProductNumber = "PLU32323";
            two.ProductDescription = "This is a XML manago";
            list.Add(two);
            return list;
        }
    }
}
