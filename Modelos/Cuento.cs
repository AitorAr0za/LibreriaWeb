using LibreriaWeb.Enums;
using LibreriaWeb.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaWeb.Modelos
{
    class Cuento : ILibro
    {
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public CategoriaLibro CategoriaLibro { get; set; }
        public Cuento(string nombre, int stock)
        {
            Nombre = nombre;
            Stock = stock;
            CategoriaLibro = CategoriaLibro.Cuento;
        }
        public void DisminuirStock(int id)
        {
            Stock = Stock - id;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"{Nombre} - Stock: {Stock}");
        }
    }
}
