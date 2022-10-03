using ClienteBlazor.AccesoriosMoviles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClienteBlazor.AccesoriosMoviles.Services
{
    public class ProductoService : IProductoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public ProductoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Producto>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Producto");
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(resp, options);
        }

        public async Task<IEnumerable<Producto>> GetByCategoria(int idCategoria)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Producto/Buscar", new { idCategoria = idCategoria });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(respString, options);
        }

        public async Task<Producto> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Producto/{id}");
            return JsonSerializer.Deserialize<Producto>(resp, options);
        }
    }
}