using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: pide nombre, edad, estatura y si la persona trabaja, y muestra una ficha
con interpolación junto al año en que cumplirá 30 años.
 */

namespace FichaPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ANIO_ACTUAL = 2026;

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Estatura en metros: ");
            double estatura = Convert.ToDouble(Console.ReadLine());

            // el usuario escribe true o false
            Console.Write("¿Trabaja? (true/false): ");
            bool trabaja = Convert.ToBoolean(Console.ReadLine());

            // años que le faltan para los 30, sumados al año actual
            int anioTreinta = ANIO_ACTUAL + (30 - edad);

            Console.WriteLine();
            Console.WriteLine("========== FICHA PERSONAL ==========");
            Console.WriteLine($"Nombre:    {nombre}");
            Console.WriteLine($"Edad:      {edad} años");
            Console.WriteLine($"Estatura:  {estatura} m");
            Console.WriteLine($"Trabaja:   {trabaja}");
            Console.WriteLine($"Cumple 30 años en: {anioTreinta}");
            Console.WriteLine("====================================");
        }
    }
}
