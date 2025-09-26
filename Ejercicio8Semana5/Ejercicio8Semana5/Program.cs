using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8Semana5
{
    internal class Program
    {
        static bool EsConstrasenaValida(string password)
        {
            if (password.Length < 8)
                return false;

            bool tieneMayuscula = false;
            bool tieneMinuscula = false;
            bool tieneNumero = false;
            bool tieneCaracterEspecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    tieneMayuscula = true;
                else if (char.IsLower(c))
                    tieneMinuscula = true;
                else if (char.IsDigit(c))
                    tieneNumero = true;
                else if (!char.IsLetterOrDigit(c))
                    tieneCaracterEspecial = true;
            }

            return tieneMayuscula && tieneMinuscula && tieneNumero && tieneCaracterEspecial;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una contraseña:");
            string password = Console.ReadLine();

            if (EsConstrasenaValida(password))
                Console.WriteLine("La contraseña es válida.");
            else
                Console.WriteLine("La contraseña no es válida. Debe tener al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial.");
        }
    }
}
