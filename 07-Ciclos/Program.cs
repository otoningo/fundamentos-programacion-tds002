using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: pide un número del 1 al 12 validado con do-while, muestra su tabla de
multiplicar con while y al final la suma de todos los resultados.
 */

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            // do-while: se pide al menos una vez y se repite mientras el número no sirva
            do
            {
                Console.Write("Escribe un número entre 1 y 12: ");
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    numero = 0; // si no es número se fuerza a un valor inválido para repetir
                }
            } while (numero < 1 || numero > 12);

            Console.WriteLine();
            Console.WriteLine($"Tabla del {numero}");

            int contador = 1; // contador del ciclo
            int suma = 0;     // acumulador de los resultados

            while (contador <= 12)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {resultado}");
                suma += resultado;
                contador++;
            }

            Console.WriteLine();
            Console.WriteLine($"Suma de todos los resultados: {suma}");
        }
    }
}
