using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Model.SubEntity
{
    public class Bill
    {
        public List<Product>? Products { get; set; }

        public int OrderId { get; set; }

        public List<int>? Quantity { get; set; }

        public double SumPrice { get; set; }

        public Bill() { }
    }
}
