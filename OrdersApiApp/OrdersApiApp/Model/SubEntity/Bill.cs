using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Model.SubEntity
{
    public class Bill
    {
        public List<Product>? products { get; set; }

        public int orderId { get; set; }

        public List<int>? quantity { get; set; }

        public double sumPrice { get; set; }
    }
}
