using OrdersApiApp.Model.Entity;
using Microsoft.EntityFrameworkCore;
using OrdersApiApp.Model.Connection;

namespace OrdersApiApp.Service.ClientService
{
    public class DbDaoClient : IDaoClient
    {
        public DbSet<Client>? Clients { set; get; }

        public DbSet<Order>? Orders { set; get; }

        private ApplicationDBContext db;

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(c => c.client)
                .WithMany(o => o.Orders)
                .OnDelete(DeleteBehavior.Restrict);
        }*/

        public async Task<Client> AddClient(Client client)
        {
            await db.Clients.AddAsync(client);
            await db.SaveChangesAsync();
            return client;
        }

        public async Task<bool> DeleteClient(int id)
        {
            Client? client = await db.Clients
                .FirstOrDefaultAsync((client) => client.Id == id);
            if (client != null)
            {
                db.Clients.Remove(client);
                await db.SaveChangesAsync();
            }
            return client != null;
        }

        public async Task<List<Client>> GetAllClients()
        {
            return await db.Clients.ToListAsync();
        }

        public async Task<Client> GetClientById(int id)
        {
            return await db.Clients.FirstOrDefaultAsync((client) => client.Id == id);
        }

        public async Task<Client> UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
