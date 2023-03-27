using Microsoft.EntityFrameworkCore;
using OrdersApiApp.Model.Connection;
using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Service.ProductService
{
    public class DbDaoProduct : IDaoProduct
    {
        private ApplicationDBContext db;

        public DbSet<Order> Orders { set; get; }

        public DbDaoProduct(ApplicationDBContext db) => this.db = db;

        public async Task<Product> AddProduct(Product product)
        {
            await db.Products.AddAsync(product);
            await db.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            Product? product = await db.Products
                .FirstOrDefaultAsync((product) => product.Id == id);
            if(product != null)
            {
                db.Products.Remove(product);
                await db.SaveChangesAsync();
            }
            return product != null;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await db.Products.ToListAsync<Product>();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await db.Products.FirstOrDefaultAsync((product) => product.Id == id);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
