using Microsoft.EntityFrameworkCore;
using NaturalFarma.Context;
using NaturalFarma.Repositories.Interfaces;
using NaturalFarma.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
//builder.Services.AddTransient<IOrderRepository, OrderRepository>(); // order se refere a pedido 
//builder.Services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>(); // vai ser criado no futuro lembrar de colocar o mesmo nome 
//builder.Services.AddScoped<SalesServiceReport>(); // significa relatorio de venda serviço
//builder.Services.AddScoped <ChartSaleService>(); // grafico venda serviço

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// continuar modificando para mudar para classe program.cs