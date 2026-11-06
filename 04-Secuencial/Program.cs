using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: conversor de unidades. Pide un peso en libras y una temperatura en °F,
y los convierte a kilogramos y a °C.
 */

namespace Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 libra equivale a 0.453592 kilogramos
            const double KG_POR_LIBRA = 0.453592;

            // entrada
            Console.Write("Escribe el peso en libras: ");
            double libras = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe la temperatura en °F: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // proceso
            double kilogramos = libras * KG_POR_LIBRA;
            double celsius = (fahrenheit - 32) * 5 / 9;

            // salida
            Console.WriteLine();
            Console.WriteLine($"{libras} lb equivalen a {kilogramos:F2} kg");
            Console.WriteLine($"{fahrenheit} °F equivalen a {Math.Round(celsius, 2)} °C");
        }
    }
}
