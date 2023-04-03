using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Model.SubEntity
{
    public class Bill
    {
        public double Sum { set; get; }

        public List<double>? Prices { set; get; }
        
        public List<String>? Products { get; set; }

        public Bill(double sum, List<double>? prices, List<string>? products)
        {
            Sum = sum;
            Prices = prices;
            Products = products;
        }
    }
}
