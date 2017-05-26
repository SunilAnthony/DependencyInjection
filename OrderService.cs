using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class OrderService
    {
        private IOrderSaver orderSaver;
        public OrderService(IOrderSaver orderSaver)
        {
            this.orderSaver = orderSaver;
        }
        public void SaveOrder(Order order)
        {
            orderSaver.SaveOrder(order);
        }
        public void UpdateOrder(int id)
        {
            orderSaver.UpdateOrder(id);
        }
        public void DeleteOrder(int id)
        {
            orderSaver.DeleteOrder(id);
        }
        public Order ViewOrder(int id)
        {
           return orderSaver.ViewOrder(2);
        }
        public List<Order> ViewOrders(string pNumber)
        {
            return orderSaver.ViewOrders(pNumber);
        }

    }
}
