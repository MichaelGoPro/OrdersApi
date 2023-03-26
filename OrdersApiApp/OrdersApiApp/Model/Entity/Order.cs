using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace OrdersApiApp.Model.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int ProductId { get; set; }

        public Client client { get; set; }

        public Product product { get; set; }

        public ICollection<Client> Clients { get; set; }


        [JsonIgnore]
        ICollection<Product> Products { get; set; }

        public Order()
        {

        }

        public Order(int id, int clientId, int productId)
        {
            Id = id;
            ClientId = clientId;
            ProductId = productId;
        }

        public override string ToString()
        {
            return $"{Id} - {ClientId} - {ProductId}";
        }
    }
}
