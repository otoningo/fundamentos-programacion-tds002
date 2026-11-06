using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: programa que pide nombre, edad y estatura, calcula el año de nacimiento
con la constante ANIO_ACTUAL y muestra todo usando interpolación de cadenas.
 */

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // constante con el año actual, no cambia durante el programa
            const int ANIO_ACTUAL = 2026;

            // pedir los datos al usuario
            Console.Write("Escribe tu nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Escribe tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe tu estatura en metros (ej. 1.75): ");
            double estatura = Convert.ToDouble(Console.ReadLine());

            // el año de nacimiento sale de restar la edad al año actual
            int anioNacimiento = ANIO_ACTUAL - edad;

            Console.WriteLine();
            Console.WriteLine("===== DATOS =====");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura} m");
            Console.WriteLine($"Año de nacimiento aproximado: {anioNacimiento}");
        }
    }
}
