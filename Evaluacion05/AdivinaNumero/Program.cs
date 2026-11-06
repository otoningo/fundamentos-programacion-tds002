using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: el programa guarda un número secreto del 1 al 100 y el usuario intenta
adivinarlo. En cada intento se le dice si es mayor o menor y al final cuántos intentos usó.
 */

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Next(1, 101) da un número del 1 al 100 (el 101 no entra)
            int secreto = Random.Shared.Next(1, 101);
            int intentos = 0;
            int numero = 0;

            Console.WriteLine("Adivina el número secreto entre 1 y 100.");

            while (numero != secreto)
            {
                Console.Write("Tu número: ");

                if (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 100)
                {
                    Console.WriteLine("Escribe un número entero entre 1 y 100.");
                    numero = 0; // no cuenta como intento
                    continue;
                }

                intentos++;

                if (numero < secreto)
                {
                    Console.WriteLine("El número secreto es mayor.");
                }
                else if (numero > secreto)
                {
                    Console.WriteLine("El número secreto es menor.");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"¡Correcto! El número era {secreto}.");
            Console.WriteLine($"Lo adivinaste en {intentos} intento(s).");
        }
    }
}
