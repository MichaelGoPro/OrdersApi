namespace OrdersApiApp.Model.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = " ";

        public string? Description { get; set; }

        public double Price { get; set; }

        public int Order_ProductID { get; set; }

        public Order_Product order_product { set; get; }

        public Product()
        {
            Description = " ";
        }

        public Product(int id, string name, string description, double price, int order_productid)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Order_ProductId = order_productid;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Price} - {Description}";
        }
    }
}
