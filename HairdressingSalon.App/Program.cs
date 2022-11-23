using AutoMapper;
using HairdressingSalon.App;
using HairdressingSalon.BLL.Interfaces;
using HairdressingSalon.BLL.Services;
using HairdressingSalon.DAL;
using HairdressingSalon.DAL.Database;
using HairdressingSalon.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"), b =>
        b.MigrationsAssembly("HairdressingSalon.DAL")));

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

builder.Services.AddScoped<IClientsService, ClientsService>();
builder.Services.AddScoped<IWorkersService, WorkersService>();
builder.Services.AddScoped<IFeedbacksService, FeedbacksService>();
builder.Services.AddScoped<IOrdersService, OrdersService>();
builder.Services.AddScoped<IServiceKindsService, ServiceKindsService>();
builder.Services.AddScoped<IServicesService, ServicesService>();

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingConfig());
});

IMapper autoMapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(autoMapper);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.Map("/FillTables", Extensions.FillTables);

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/");

app.Run();
