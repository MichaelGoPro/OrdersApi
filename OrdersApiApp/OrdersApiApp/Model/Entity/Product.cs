namespace OrdersApiApp.Model.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = " ";

        public string? Description { get; set; }

        public Product()
        {
            Description = " ";
        }

        public Product(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Description}";
        }
    }
}
