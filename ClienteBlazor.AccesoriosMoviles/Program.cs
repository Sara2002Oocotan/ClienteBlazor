using ClienteBlazor.AccesoriosMoviles.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBlazor.AccesoriosMoviles
{
    public class Programa
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.accesorios.somee.com/api/") });
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44376/api/") });
            builder.Services.AddScoped<ICategoriaService, CategoriaService>();
            builder.Services.AddScoped<IProductoService, ProductoService>();

            builder.Services.AddMudServices(); 

            await builder.Build().RunAsync();
        }
    }
}
