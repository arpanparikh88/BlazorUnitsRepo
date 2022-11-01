global using BlazorUnitsApp.Shared;
global using System.Net.Http.Json;
using BlazorUnitsApp.Client;
using BlazorUnitsApp.Client.Services.ProductService;
using BlazorUnitsApp.Client.Services.UnitService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUnitService, UnitService>();

await builder.Build().RunAsync();
