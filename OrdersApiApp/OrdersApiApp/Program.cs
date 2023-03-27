using OrdersApiApp.Model;
using OrdersApiApp.Model.Entity;
using OrdersApiApp.Service.ClientService;
using OrdersApiApp.Service.OrderService;
using OrdersApiApp.Service.Order_ProductService;
using OrdersApiApp.Service.ProductService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDBContext>();
builder.Services.AddTransient<IDaoClient, DbDaoClient>();
builder.Services.AddTransient<IDaoOrder, DbDaoOrder>();
builder.Services.AddTransient<IDaoProduct, DbDaoProduct>();

var app = builder.Build();


//------------------------Client methods ------------------------------


app.MapGet("/client/all", async (HttpContext context, IDaoClient dao) =>
{
    return await dao.GetAllClients();
});
app.MapGet("/client/by_id", async (HttpContext context, IDaoClient dao, int id) =>
{
    return await dao.GetClientById(id);
});

app.MapPost("/client/add", async (HttpContext context, Client client, IDaoClient dao) =>
{
    return await dao.AddClient(client);
});

app.MapPost("/client/delete", async (HttpContext context, IDaoClient dao, int id) =>
{
    return await dao.DeleteClient(id);
});

app.MapPost("/client/update", async (HttpContext context, IDaoClient dao, Client client) =>
{
    return await dao.UpdateClient(client);
});


//------------------------Order methods ------------------------------


app.MapGet("/order/all", async (HttpContext context, IDaoOrder dao) =>
{
    return await dao.GetAllOrders();
});

app.MapPost("/order/add", async (HttpContext context, Order order, IDaoOrder dao) =>
{
    return await dao.AddOrder(order);
});

app.MapGet("/order/by_id", async (HttpContext context, IDaoOrder dao, int id) =>
{
    return await dao.GetOrderById(id);
});

app.MapPost("/order/delete", async (HttpContext context, IDaoOrder dao, int id) =>
{
    return await dao.DeleteOrder(id);
});

app.MapPost("/order/update", async (HttpContext context, IDaoOrder dao, Order order) =>
{
    return await dao.UpdateOrder(order);
});



//------------------------Product methods--------------------------------


app.MapGet("/product/all", async (HttpContext context, IDaoProduct dao) =>
{
    return await dao.GetAllProducts();
});

app.MapPost("/product/add", async (HttpContext context, Product product, IDaoProduct dao) =>
{
    return await dao.AddProduct(product);
});

app.MapGet("/product/by_id", async (HttpContext context, IDaoProduct dao, int id) =>
{
    return await dao.GetProductById(id);
});

app.MapPost("/product/delete", async (HttpContext context, IDaoProduct dao, int id) =>
{
    return await dao.DeleteProduct(id);
});

app.MapPost("/product/update", async (HttpContext context, IDaoProduct dao, Product product) =>
{
    return await dao.AddProduct(product);
});


//------------------------Order-Product methods--------------------------


app.MapGet("/order_product/all", async (HttpContext context, IDaoOrderProduct dao) =>
{
    return await dao.GetAllOrders_Products();
});

app.MapPost("/order_product/add", async (HttpContext context, Order_Product order_product, IDaoOrderProduct dao) =>
{
    return await dao.AddOrder_Product(order_product);
});

app.MapGet("/order_product/by_id", async (HttpContext context, IDaoOrderProduct dao, int id) =>
{
    return await dao.GetOrder_ProductById(id);
});

app.MapPost("/order_product/delete", async (HttpContext context, IDaoOrderProduct dao, int id) =>
{
    return await dao.DeleteOrder_Product(id);
});

app.MapPost("/order_product/update", async (HttpContext context, IDaoOrderProduct dao, Order_Product order_product) =>
{
    return await dao.AddOrder_Product(order_product);
});


app.Run();