using BethanyPieShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); //does some basic setup of the asp.net core platform.
                                                  //Set up Kestrel server. Configure IIS integration. Specify content root.
                                                  //Configuration information is read form a file called appsettings.json



builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); //pass our interface, register the repository
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp)); //will invoke GetCart method, passing serive provider
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor(); //we are able to do IHttpContextAccessor part in ShoppingCart

// Add services to the container.
builder.Services.AddControllersWithViews(); //will register VMC service
builder.Services.AddDbContext<BethanysPieShopDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BethanysPieShopDbContextConnection"]);
});

var app = builder.Build(); //final step of initialization.The resulting app is then of type webapp and
                           //that is used to set up the middleware components and the middleware pipeline.

//middleware components build up what is known as the middleware request pipeline 
//app.MapGet("/", () => "Hello World!"); //middleware component that listens for an incoming request to the root
//of the application and will return hello world.


app.UseStaticFiles(); //bring in support for returning static files. Will look for wwwroot for that file and return it.
app.UseSession(); //enables session, it doesn't nedd any additional nugetPackages

if (app.Environment.IsDevelopment()) //check if application is currently running in development mode.In another case we don't display this page.
{
    app.UseDeveloperExceptionPage(); // a diagnostic middleware component that will not always show exception page.
                                     // A info we don't want our users to see.
}


app.MapDefaultControllerRoute(); //navigate to our pages to. Make sure that ASP.NET core will be able to handle
                                 //incoming requests correctly
DbInitializer.Seed(app);
app.Run();
