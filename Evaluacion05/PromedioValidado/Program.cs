using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: pide notas del 0 al 100 hasta que el usuario escribe -1. Cada nota se valida
con do-while y TryParse. Al final muestra el promedio, la nota mayor y la menor.
 */

namespace PromedioValidado
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadNotas = 0;
            double sumaNotas = 0;
            double notaMayor = 0;
            double notaMenor = 100;
            double nota;

            Console.WriteLine("Escribe las notas (0-100). Escribe -1 para terminar.");

            do
            {
                bool notaValida;

                // se repite hasta que la nota sea un número entre 0 y 100, o -1 para salir
                do
                {
                    Console.Write($"Nota {cantidadNotas + 1}: ");
                    notaValida = double.TryParse(Console.ReadLine(), out nota)
                                 && ((nota >= 0 && nota <= 100) || nota == -1);

                    if (!notaValida)
                    {
                        Console.WriteLine("Nota inválida, tiene que estar entre 0 y 100.");
                    }
                } while (!notaValida);

                if (nota != -1)
                {
                    cantidadNotas++;
                    sumaNotas += nota;

                    if (nota > notaMayor)
                    {
                        notaMayor = nota;
                    }
                    if (nota < notaMenor)
                    {
                        notaMenor = nota;
                    }
                }
            } while (nota != -1);

            Console.WriteLine();
            // si no se escribió ninguna nota no se puede sacar promedio (sería dividir entre 0)
            if (cantidadNotas > 0)
            {
                double promedio = sumaNotas / cantidadNotas;
                Console.WriteLine($"Notas registradas: {cantidadNotas}");
                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Nota mayor: {notaMayor}");
                Console.WriteLine($"Nota menor: {notaMenor}");
            }
            else
            {
                Console.WriteLine("No se registró ninguna nota.");
            }
        }
    }
}
