using DynamicDiscountSystemEx.Services.Classes;
using DynamicDiscountSystemEx.Services.Interfaces;
using DynamicDiscountSystemEx.Strategy.Classes;
using DynamicDiscountSystemEx.Strategy.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IDiscountService, DiscountService>();
var app = builder.Build();

app.MapGet("/", (IDiscountService discountService) =>
{
    var total = 50;


    var totalPriceAfterDiscount = discountService.ApplyDiscount(total);
    return Results.Ok(totalPriceAfterDiscount);
});

app.Run();
