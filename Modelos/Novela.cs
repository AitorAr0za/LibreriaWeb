using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaWeb.Enums;
using LibreriaWeb.Interfaces;

namespace LibreriaWeb.Modelos
{
    class Novela : ILibro
    {
        public string Nombre {  get; set; }
        public int Stock { get; set; }
        public CategoriaLibro CategoriaLibro { get; set; }
        public Novela(string nombre, int stock)
        {
            Nombre = nombre;
            Stock = stock;
            CategoriaLibro = CategoriaLibro.Novela;
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
