using Microsoft.EntityFrameworkCore;
using OrdersApiApp.Model;
using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Service.OrderService
{
    public class DbDaoOrder : IDaoOrder
    {
        private ApplicationDBContext db;

        public DbSet<Client> Clients { set; get; }
        
        public DbSet<Order> Orders { set; get; }

        public DbDaoOrder(ApplicationDBContext db) => this.db = db;

        public async Task<Order> AddOrder(Order order)
        {
            await db.Orders.AddAsync(order);
            await db.SaveChangesAsync();
            return order;
        }

        public async Task<bool> DeleteOrder(int id)
        {
            Order? order = await db.Orders.FirstOrDefaultAsync((order) => order.Id == id);
            if(order != null)
            {
                db.Orders.Remove(order);
                await db.SaveChangesAsync();
            }
            return order != null;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            await db.Clients.LoadAsync();
            return await db.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await db.Orders.FirstOrDefaultAsync((order) => order.Id == id);
        }

        public Task<Order> UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
