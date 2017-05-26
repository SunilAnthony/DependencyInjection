using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IOrderSaver
    {
        void SaveOrder(Order order);
        void DeleteOrder(int id);
        void UpdateOrder(int id);
        Order ViewOrder(int id);
        List<Order> ViewOrders(string product);
    }
}
