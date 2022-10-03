using ClienteBlazor.AccesoriosMoviles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteBlazor.AccesoriosMoviles.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetAll();
        Task<IEnumerable<Producto>> GetByCategoria(int idDepto);
        Task<Producto> GetById(int id);
    }
}
