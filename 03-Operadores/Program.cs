using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: lee dos números enteros y muestra la suma, resta, producto, división real,
división entera, residuo y si el primer número es par.
 */

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe el primer número entero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe el segundo número entero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int suma = a + b;
            int resta = a - b;
            int producto = a * b;

            Console.WriteLine();
            Console.WriteLine($"Suma: {a} + {b} = {suma}");
            Console.WriteLine($"Resta: {a} - {b} = {resta}");
            Console.WriteLine($"Producto: {a} * {b} = {producto}");

            // no se puede dividir entre 0, por eso se revisa antes
            if (b != 0)
            {
                // se convierte a double para que la división dé decimales
                double divisionReal = (double)a / b;
                int divisionEntera = a / b;
                int residuo = a % b;

                Console.WriteLine($"División real: {a} / {b} = {divisionReal:F2}");
                Console.WriteLine($"División entera: {a} / {b} = {divisionEntera}");
                Console.WriteLine($"Residuo: {a} % {b} = {residuo}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0.");
            }

            // un número es par si el residuo entre 2 es 0
            bool esPar = a % 2 == 0;
            Console.WriteLine($"¿{a} es par? {esPar}");
        }
    }
}

/*
Prueba de escritorio con x = 10, y = 3

Operación       Expresión   Resultado
Suma            x + y       13
Resta           x - y       7
Producto        x * y       30
División real   x / y       3.33 (con double)
División entera x / y       3
Residuo         x % y       1
¿x es par?      x % 2 == 0  true (10 % 2 = 0)
 */
