using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OrdersApiApp.Model.Entity
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        [NotMapped]
        public ICollection<Order> Orders { get; set; }  

        public Client()
        {
            Name = "";
        }

        public Client(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
