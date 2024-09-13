using LibreriaWeb.Interfaces;
using LibreriaWeb.Enums;
using LibreriaWeb.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaWeb.Modelos
{
    class Pedido : IPedido
    {
        public string Libro { get; set; }
        public int Cantidad { get; set; }
        public Pedido(string libro, int cantidad)
        {
            Libro = libro;
            Cantidad = cantidad;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Libro: {Libro}\nCantidad: {Cantidad}");
        }
    }
}
