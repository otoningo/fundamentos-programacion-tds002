using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: parte 1, convierte una nota de 0 a 100 en letra con if - else if - else.
Parte 2, calculadora de cuatro operaciones resuelta con switch.
 */

namespace Decisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== PARTE 1: CALIFICACIÓN =====
            Console.WriteLine("===== CALIFICACIÓN =====");
            Console.Write("Escribe la nota (0-100): ");

            // TryParse devuelve false si lo escrito no es un número, así el programa no se cae
            if (int.TryParse(Console.ReadLine(), out int nota) && nota >= 0 && nota <= 100)
            {
                string letra;
                if (nota >= 90)
                {
                    letra = "A";
                }
                else if (nota >= 80)
                {
                    letra = "B";
                }
                else if (nota >= 70)
                {
                    letra = "C";
                }
                else
                {
                    letra = "F";
                }
                Console.WriteLine($"Con {nota} la calificación es {letra}");
            }
            else
            {
                Console.WriteLine("Nota inválida, tiene que ser un número entre 0 y 100.");
            }

            // ===== PARTE 2: CALCULADORA =====
            Console.WriteLine();
            Console.WriteLine("===== CALCULADORA =====");
            Console.Write("Primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Elige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    // dividir entre 0 no tiene resultado
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0.");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2:F2}");
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
