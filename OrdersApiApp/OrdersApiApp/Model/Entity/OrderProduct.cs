namespace OrdersApiApp.Model.Entity
{
    public class Order_Product
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int Amount { get; set; }

        public Order order { get; set; }

        public Order_Product()
        {

        }

        public Order_Product(int id, int orderId, int amount)
        {
            Id = id;
            Amount = amount;
            OrderId = orderId;
        }

        public override string ToString()
        {
            return $"{Id} - {OrderId} - {Amount}";
        }
    }
}
