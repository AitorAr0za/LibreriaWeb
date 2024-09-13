using LibreriaWeb.Interfaces;
using LibreriaWeb.Modelos;
using LibreriaWeb.Enums;
class Program
{
    static void Main()
    {
        List<IPedido> Carrito = new List<IPedido>();

        List<Novela> Novelas = new List<Novela>()
        {
            new Novela("La Divina Programacion", 5),
            new Novela("Harry Coder", 10)
        };

        List<Cuento> Cuentos = new List<Cuento>()
        {
            new Cuento("Caperucita Roja", 3),
            new Cuento("El Principito", 7)
        };

        List<Poesia> Poesias = new List<Poesia>()
        {
            new Poesia("Love, Death & Enums", 12),
            new Poesia("Nombre Poetico", 20)
        };

        List<string> Logs = new List<string>
        {
            "Pepito",
            "Invitado",
            "Tarico"
        };
        
        bool swich = true;
        while (swich)
        {
            string intento = "p";
            Console.WriteLine("Ingrese su nombre de usuario: ");
            intento = Console.ReadLine();
            if (Logs.Contains(intento))
            {
                swich = false;
                Console.WriteLine($"Bienvenido {intento}");
            }
            else
            {
                Console.WriteLine("El usuario ingresado no esta registrado. Pruebe de nuevo.");
            }
        }

        bool swich2 = true;
        while (swich2) { 
            Console.WriteLine("\nSeleccione uno de los siguientes rubros de libros para escoger:" +
                "\nIngrese {1} para el rubro Novelas" +
                "\nIngrese {2} para el rubro Cuentos" +
                "\nIngrese {3} para el rubro Poesias" +
                "\n Ingrese {4} para salir del programa y ver");
            int rubro = int.Parse(Console.ReadLine());

            if (rubro == 1)
            {
                bool swich3 = true;
                while (swich3) {
                    Console.WriteLine("\nA continuacion, elija una novela y cuantas unidades comprara:\n");
                    foreach (Novela value in Novelas) 
                    { 
                        value.MostrarDatos();
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Ingrese el numero de la novela que desea comprar (por ej, si quiere comprar la primera, ingrese 0): ");
                    int LibroElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora ingrese cuantas unidades desea comprar: ");
                    int Cantidad = int.Parse(Console.ReadLine());
                    if (Novelas[LibroElegido].Stock >= Cantidad)
                    {
                        swich3 = false;
                        Novelas[LibroElegido].Stock -= Cantidad;
                        Carrito.Add(new Pedido(Novelas[LibroElegido].Nombre, Cantidad));

                    }
                    else
                    {
                        Console.WriteLine($"La cantidad de unidades que ha querido comprar sobrepasa el stock" +
                            $"actual del libro en cuestion. Por favor, compre una cantidad menor o igual a {Novelas[LibroElegido].Stock}");
                    }
                }
            }
            else if (rubro == 2)
            {
                bool swich3 = true;
                while (swich3)
                {
                    Console.WriteLine("\nA continuacion, elija un cuento y cuantas unidades comprara:\n");
                    foreach (Cuento value in Cuentos) 
                    { 
                        value.MostrarDatos();
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Ingrese el numero del cuento que desea comprar (por ej, si quiere comprar el primero, ingrese 0): ");
                    int LibroElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora ingrese cuantas unidades desea comprar: ");
                    int Cantidad = int.Parse(Console.ReadLine());
                    if (Cuentos[LibroElegido].Stock >= Cantidad)
                    {
                        swich3 = false;
                        Cuentos[LibroElegido].Stock -= Cantidad;
                        Carrito.Add(new Pedido(Cuentos[LibroElegido].Nombre, Cantidad));

                    }
                    else
                    {
                        Console.WriteLine($"La cantidad de unidades que ha querido comprar sobrepasa el stock" +
                            $"actual del libro en cuestion. Por favor, compre una cantidad menor o igual a {Cuentos[LibroElegido].Stock}");
                    }
                }
            }
            else if (rubro == 3)
            {
                bool swich3 = true;
                while (swich3)
                {
                    Console.WriteLine("A continuacion, elija un cuento y cuantas unidades comprara:\n");
                    foreach (Poesia value in Poesias) 
                    { 
                        value.MostrarDatos();
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("\nIngrese el numero del cuento que desea comprar (por ej, si quiere comprar el primero, ingrese 0): ");
                    int LibroElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora ingrese cuantas unidades desea comprar: ");
                    int Cantidad = int.Parse(Console.ReadLine());
                    if (Poesias[LibroElegido].Stock >= Cantidad)
                    {
                        swich3 = false;
                        Poesias[LibroElegido].Stock -= Cantidad;
                        Carrito.Add(new Pedido(Poesias[LibroElegido].Nombre, Cantidad));
                    }
                    else
                    {
                        Console.WriteLine($"La cantidad de unidades que ha querido comprar sobrepasa el stock" +
                            $"actual del libro en cuestion. Por favor, compre una cantidad menor o igual a {Poesias[LibroElegido].Stock}");
                    }
                }
            }
            else if (rubro == 4)
            {
                Console.WriteLine("Este es su carrito actual:");
                foreach (Pedido value in Carrito)
                { 
                    value.MostrarInformacion();
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Ingrese 1 para continuar e ingresar los datos de su tarjeta o 2 para retroceder y seguir comprando: ");
                int Input = int.Parse(Console.ReadLine());
                if (Input == 1) { swich2 = false; }
            }
        }
        Console.WriteLine("\nBien, Ingrese el numero de su tarjeta: ");
        ulong NumeroTarjeta = ulong.Parse(Console.ReadLine());

        Console.WriteLine("\nAhora ingrese el codigo de seguridad: ");
        int CodigoSeguridad = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nFinalmente, ingrese el mes de la fecha de caducidad: ");
        int MesCaducidad = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nAño de caducidad: ");
        int AnioCaducidad = int.Parse(Console.ReadLine());
        if (AnioCaducidad < 2024)
        {
            Console.WriteLine("Su tarjeta ha caducado. Reinicie el programa y pruebe de nuevo.");
        }
        else if (AnioCaducidad == 2024 && MesCaducidad < 10)
        {
            Console.WriteLine("Su tarjeta ha caducado. Reinicie el programa y pruebe de nuevo.");
        }
        else
        {
            Console.WriteLine("\nCompra exitosa! Estos son los libros que ha comprado: ");
            foreach (IPedido value in Carrito) 
            {
                value.MostrarInformacion();
                Console.WriteLine("\n");
            }

        }
    }
}

