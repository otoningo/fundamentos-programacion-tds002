using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: caja registradora que lee precios hasta que el usuario escribe 0 y muestra
la cantidad de productos, el subtotal, el ITBIS y el total.
 */

namespace CajaRegistradora
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ITBIS = 0.18;

            int cantidadProductos = 0; // contador
            double subtotal = 0;       // acumulador
            double precio;

            Console.WriteLine("Escribe los precios uno por uno. Escribe 0 para terminar.");

            do
            {
                Console.Write($"Precio del producto {cantidadProductos + 1}: ");

                // si no es un número válido o es negativo, se avisa y se vuelve a pedir
                if (!double.TryParse(Console.ReadLine(), out precio) || precio < 0)
                {
                    Console.WriteLine("Precio inválido, intenta otra vez.");
                    precio = -1; // valor para que no termine el ciclo ni se sume
                }
                else if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
            } while (precio != 0);

            double montoItbis = subtotal * ITBIS;
            double total = subtotal + montoItbis;

            Console.WriteLine();
            Console.WriteLine("========== RESUMEN ==========");
            Console.WriteLine($"Productos:      {cantidadProductos,12}");
            Console.WriteLine($"Subtotal:       {subtotal,12:N2}");
            Console.WriteLine($"ITBIS (18 %):   {montoItbis,12:N2}");
            Console.WriteLine($"Total:          {total,12:N2}");
        }
    }
}
