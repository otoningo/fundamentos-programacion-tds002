using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: pide producto, cantidad y precio, calcula subtotal, ITBIS y total,
y los muestra como una factura con columnas alineadas.
 */

namespace Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ITBIS = 0.18;

            // entrada
            Console.Write("Producto: ");
            string producto = Console.ReadLine() ?? "";

            Console.Write("Cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Precio unitario (RD$): ");
            double precio = Convert.ToDouble(Console.ReadLine());

            // proceso
            double subtotal = cantidad * precio;
            double montoItbis = subtotal * ITBIS;
            double total = subtotal + montoItbis;

            // salida: PadRight deja el texto a la izquierda y {valor,10} alinea los números a la derecha
            Console.WriteLine();
            Console.WriteLine("================ FACTURA ================");
            Console.WriteLine("Producto".PadRight(18) + "Cant.".PadLeft(6) + "Precio".PadLeft(15));
            Console.WriteLine($"{producto.PadRight(18)}{cantidad,6}{precio,15:N2}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{"Subtotal:".PadRight(24)}{subtotal,15:N2}");
            Console.WriteLine($"{"ITBIS (18 %):".PadRight(24)}{montoItbis,15:N2}");
            Console.WriteLine($"{"TOTAL:".PadRight(24)}{total,15:N2}");
            Console.WriteLine("=========================================");
        }
    }
}
