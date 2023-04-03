using Microsoft.EntityFrameworkCore;
using OrdersApiApp.Model.Connection;
using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Service.Order_ProductService
{
    public class DbDaoOrder_Product : IDaoOrderProduct
    {
        private ApplicationDBContext db;

        public DbDaoOrder_Product(ApplicationDBContext db) => this.db = db;

        public async Task<Order_Product> AddOrder_Product(Order_Product order_product)
        {
            await db.Orders_Products.AddAsync(order_product);
            await db.SaveChangesAsync();
            return order_product;
        }

        public async Task<bool> DeleteOrder_Product(int id)
        {
            Order_Product? order_product = await db.Orders_Products
                .FirstOrDefaultAsync((order_product) => order_product.Id == id);
            await db.SaveChangesAsync();
            return order_product != null;
        }

        public async Task<List<Order_Product>> GetAllOrders_Products()
        {
            return await db.Orders_Products.ToListAsync<Order_Product>();
        }

        public async Task<Order_Product> GetOrder_ProductById(int id)
        {
            Order_Product? order_product = await db.Orders_Products
                .FirstOrDefaultAsync((order_product) => order_product.Id == id);
            await db.SaveChangesAsync();
            return order_product;
        }

        public async Task<Order_Product> UpdateOrder_Product(Order_Product order_product)
        {
            return order_product;
        }
    }
}
