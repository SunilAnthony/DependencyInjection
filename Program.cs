using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Order one = new Order();
            one.Id = 1;
            one.ProductNumber = "PLU32323";
            one.ProductDescription = "This is a green manago";

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var db = kernel.Get<IOrderSaver>();

            var order = new OrderService(db);
            
            var result = order.ViewOrders("PLU");
            foreach(var item in result)
            {
                Console.WriteLine("Id: {0}", item.Id);
                Console.WriteLine("Product No: {0}", item.ProductNumber);
                Console.WriteLine("Product Description: {0}", item.ProductDescription);
                Console.WriteLine("---======New Order=========----");
            }
            Console.ReadLine();
        }
    }
}
