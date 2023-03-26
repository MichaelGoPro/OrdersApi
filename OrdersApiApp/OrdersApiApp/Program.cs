using OrdersApiApp.Model;
using OrdersApiApp.Model.Entity;
using OrdersApiApp.Service.ClientService;
using OrdersApiApp.Service.OrderService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDBContext>();
builder.Services.AddTransient<IDaoClient, DbDaoClient>();
builder.Services.AddTransient<IDaoOrder, DbDaoOrder>();

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



//------------------------Order methods ------------------------------

app.MapGet("/order/all", async (HttpContext context, IDaoOrder dao) =>
{
    return await dao.GetAllOrders();
});

app.MapPost("/order/add", async (HttpContext context, Order order, IDaoOrder dao) =>
{
    return await dao.AddOrder(order);
});

app.Run();
