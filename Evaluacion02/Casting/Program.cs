using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: demuestra el casting explícito de double a int (parte entera) y el
casting implícito de int a double.
 */

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe un número con decimales: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // casting explícito: se pierde la parte decimal, por eso hay que escribir (int)
            int parteEntera = (int)numero;

            Console.WriteLine();
            Console.WriteLine($"Número original: {numero}");
            Console.WriteLine($"Parte entera con (int): {parteEntera}");

            // casting implícito: un int cabe completo en un double, así que no hace falta escribir nada
            int entero = parteEntera;
            double comoDouble = entero;

            Console.WriteLine($"El int {entero} pasado a double queda como {comoDouble:F1}");
        }
    }
}
