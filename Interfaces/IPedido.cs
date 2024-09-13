using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaWeb.Enums;
using LibreriaWeb.Modelos;

namespace LibreriaWeb.Interfaces
{
    public interface IPedido
    {
        string Libro { get; set; }
        int Cantidad { get; set; }
        void MostrarInformacion();
    }
}
