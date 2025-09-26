
//7. Simulador de Tienda en Línea
//• Declara una variable global carritoTotal.
//• Crea métodos con variables locales para:
//✓ Agregar un producto (sumando su precio al total).
//✓ Eliminar un producto.
//✓ Consultar el total actual de la compra.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7Semana5
{
    internal class Program
    {
        static double carritoTotal = 0;

        static double agregarProducto(double precio)
        {
            carritoTotal += precio;
            return carritoTotal;
        }
        static double eliminarProducto(double precio)
        {
            carritoTotal -= precio;
            return carritoTotal;
        }
        static double totalCarrito()
        {
            return carritoTotal;
        }   
        static void Main(string[] args)
        {
            double precio;
            char continuar = 'y';
            do
            {
                Console.WriteLine("Bienvenido a la tienda UAM");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Agregar producto al carrito");
                Console.WriteLine("2. Eliminar producto del carrito");
                Console.WriteLine("3. Mostrar total del carrito");
                Console.WriteLine("Ingrese la accion que desea llevar a cabo");
                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1: 
                        Console.WriteLine("Ingrese el precio del producto que desea agregar al carrito: ");
                        precio = Convert.ToDouble(Console.ReadLine());
                        agregarProducto(precio);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el precio del producto que desea eliminar del carrito: ");
                        precio = Convert.ToDouble(Console.ReadLine());
                        eliminarProducto(precio);
                        break;
                    case 3:
                        Console.WriteLine("El total de su carrito es: C$" + totalCarrito());
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                  }
                Console.WriteLine("Desea continuar? (Y/N)");
                continuar = Convert.ToChar(Console.ReadLine().ToLower());
                if (continuar == 'n')
                {
                    Console.WriteLine("El total de su carrito es: C$" + totalCarrito());
                }

            } while(continuar != 'n');
        }
    }
}   
