using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Service.OrderService
{
    public class PlugDaoOrder
    {
        public static List<Order> orders = new List<Order>();

        public Task<Order> AddOrder(Order order)
        {
            order.Id = orders.Count;
            orders.Add(order);
            return Task.Run(() => order);
        }

        public Task<bool> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllOrders()
        {
            return Task.Run(() => orders);
        }

        public Task<Order> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateOrder(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
