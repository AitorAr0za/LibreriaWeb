using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaWeb.Enums;

namespace LibreriaWeb.Interfaces
{
    public interface ILibro
    {
        string Nombre { get; set; }
        int Stock { get; set; }
        CategoriaLibro CategoriaLibro { get; set; }
        void DisminuirStock(int id);
        void MostrarDatos();

    }
}
