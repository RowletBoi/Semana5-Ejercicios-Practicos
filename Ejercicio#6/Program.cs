//6. Sistema de Registro de Usuarios
//• Crea una lista global que almacene nombres de usuarios registrados.
//• Métodos con variables locales deben permitir:
//✓ Registrar un nuevo usuario.
//✓ Validar si un usuario ya existe.
//✓ Mostrar todos los usuarios
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Semana5
{
    internal class Program
    {
        static List<string> nombres = new List<string>();

        static void RegistrarUsuario(string nombre)
        {
            nombres.Add(nombre);
        }
        static void MostrarUsuarios()
        {
            Console.WriteLine("Usuarios registrados:");
            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }

        static bool UsuarioDuplicado(string nombre)
        {
            if (nombres.Contains(nombre))
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            string nombre;
            do
            {
                Console.WriteLine("\n\nIngrese un nombre de usuario (o 'salir' para terminar):");
                nombre = Console.ReadLine();
                if (nombre.ToLower() != "salir")
                {
                    if (UsuarioDuplicado(nombre))
                    {
                        Console.WriteLine("\nEl nombre de usuario ya está registrado. Intente con otro.");
                    }
                    else
                    {
                        RegistrarUsuario(nombre);
                        Console.WriteLine("\nUsuario registrado exitosamente.");
                    }
                }
                if (nombres.Count > 0)
                {
                    MostrarUsuarios();
                    Console.WriteLine("\n\n\n\n");
                }
                if (nombre == "salir")
                {
                    Console.WriteLine("\nSaliendo...");
                }

            } while (nombre != "salir");
            
        }
    }
}