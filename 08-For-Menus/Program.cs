using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: menú con do-while y switch que muestra las tablas del 1 al 10 en columnas
(ciclos anidados) o dibuja un triángulo de asteriscos de N filas.
 */

namespace ForMenus
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== MENÚ =====");
                Console.WriteLine("1. Tablas del 1 al 10");
                Console.WriteLine("2. Triángulo de asteriscos");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }

                switch (opcion)
                {
                    case 1:
                        // ciclo de afuera: las filas (1 al 10), ciclo de adentro: las columnas
                        for (int fila = 1; fila <= 10; fila++)
                        {
                            for (int columna = 1; columna <= 10; columna++)
                            {
                                Console.Write($"{fila * columna,4}");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.Write("¿Cuántas filas? ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            // en cada fila se imprimen tantos asteriscos como el número de la fila
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tiene que ser un número mayor que 0.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
