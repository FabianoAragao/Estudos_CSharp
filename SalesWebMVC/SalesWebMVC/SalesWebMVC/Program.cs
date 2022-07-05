using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMVC.Models;
using SalesWebMVC.Data;
using SalesWebMVC.Servicos;
var 
    builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SalesWebMVCContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SalesWebMVCContext") ,
    builder => builder.MigrationsAssembly("SalesWebMVC")));

builder.Services.AddScoped<ServicoDeSeeding>();
builder.Services.AddScoped<ServicoVendedor>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// converte as datas para um tipo que o postgres compreende
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetService<SalesWebMVCContext>();

        ServicoDeSeeding servicoDeSeeding = new ServicoDeSeeding(context);

        servicoDeSeeding.seed();
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
