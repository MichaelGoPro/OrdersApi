using Microsoft.EntityFrameworkCore;
using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Service.Order_ProductService
{
    public interface IDaoOrderProduct
    {
        Task<List<Order_Product>> GetAllOrders_Products();
        Task<Order_Product> GetOrder_ProductById(int id);
        Task<Order_Product> AddOrder_Product(Order_Product order_product);
        Task<Order_Product> UpdateOrder_Product(Order_Product order_product);
        Task<bool> DeleteOrder_Product(int id);
    }
}
