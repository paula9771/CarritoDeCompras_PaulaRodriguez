using System;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int CantCamisas = 0;
            int TotalCamisas = 0;
            int Precio = 0;
            int Descuento = 0;
            double PrecioTotal = 0;
            double MontoDescuento = 0;
            double TotalConDescuento = 0;
            
            





            do
            {
                Console.WriteLine("-Bienvenido a SHOPPING ONLINE-Ventas por mayor y menor-");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("\n" +
                    "\n 1. Añadir camisa al carrito" +
                    "\n 2. Eliminar camisa del carrito" +
                    "\n 3. Salir");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Cantidad de camisas en el carrito: " + TotalCamisas);
                Console.WriteLine("Precio por unidad: $1000");
                Console.WriteLine("Total: $" + PrecioTotal);
                Console.WriteLine("Descuento aplicado: " + Descuento + "%");
                Console.WriteLine("Precio final con descuento: $" + TotalConDescuento);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Ingrese la opcion deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        CantCamisas = CantCamisas + 1;
                        TotalCamisas = CantCamisas;
                        Precio = Precio + 1000;
                        PrecioTotal = Precio;
                        if (CantCamisas >= 3 && CantCamisas <= 5)
                        {
                            Descuento = 10;
                            Console.WriteLine("¡Se aplicará un descuento del 10%!");
                            MontoDescuento = 0.10 * PrecioTotal;
                            TotalConDescuento = PrecioTotal - MontoDescuento;

                        }
                        if (CantCamisas > 5)
                        {
                            Descuento = 20;
                            Console.WriteLine("¡Se aplicará un descuento del 20%!");
                            MontoDescuento = 0.20 * PrecioTotal;
                            TotalConDescuento = PrecioTotal - MontoDescuento;
                        }

                        Console.WriteLine("¡Se ha añadido una camisa al carrito!");
                        break;
                    case 2:
                        CantCamisas = CantCamisas - 1;
                        TotalCamisas = CantCamisas;
                        Precio = Precio - 1000;
                        PrecioTotal = Precio;
                        Console.WriteLine("¡Se eliminó una camisa del carrito!");
                        break;
                    case 3:
                        char Salida;
                        Console.WriteLine("¿Está seguro que desea salir? S/N ");
                        Salida = Convert.ToChar(Console.ReadLine()[0]);
                        if (Salida == 'S')
                        {
                            Console.WriteLine("Saliendo...");
                            Environment.Exit(0);
                        }
                        else if (Salida == 'N')
                        {
                            opcion=0; 
                        }
                        break;
                }
            } while (opcion != 3);
        }
    }
}
