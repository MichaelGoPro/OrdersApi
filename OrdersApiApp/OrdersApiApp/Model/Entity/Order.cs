using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace OrdersApiApp.Model.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public Client client { get; set; }
                
        [NotMapped]
        public ICollection<Client> Clients { get; set; }

                public Order()
        {

        }

        public Order(int id, int clientId)
        {
            Id = id;
            ClientId = clientId;
        }

        public override string ToString()
        {
            return $"{Id} - {ClientId}";
        }
    }
}
