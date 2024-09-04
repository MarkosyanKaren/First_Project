using First_Project.BLL.Interfaces;
using First_Project.BLL.Services;
using First_Project.DAL;
using First_Project.DAL.Interfaces;
using First_Project.DAL.Repositories;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProjectDBContext>();

builder.Services.AddTransient<ICustomerRepo, CustomerRepo>();
builder.Services.AddTransient<ITourRepo, TourRepo>();
builder.Services.AddTransient<IBookingRepo, BookingRepo>();
builder.Services.AddTransient<IPaymentRepo, PaymentRepo>();

builder.Services.AddTransient<ICustomerService, CustomerService>();
builder.Services.AddTransient<ITourService, TourService>();
builder.Services.AddTransient<IBookingService, BookingService>();
builder.Services.AddTransient<IPaymentService, PaymentService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
