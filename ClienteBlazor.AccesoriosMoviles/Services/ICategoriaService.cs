using ClienteBlazor.AccesoriosMoviles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteBlazor.AccesoriosMoviles.Services
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAll();
    }
}
