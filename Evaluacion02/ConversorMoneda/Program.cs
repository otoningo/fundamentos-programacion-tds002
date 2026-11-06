using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: convierte un monto en pesos dominicanos a dólares usando la tasa del día
guardada en una constante.
 */

namespace ConversorMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            // tasa de venta del Banco Central (RD$ por cada US$)
            const double TASA_USD = 61.10;

            Console.Write("Escribe el monto en pesos (RD$): ");
            double montoPesos = Convert.ToDouble(Console.ReadLine());

            // para pasar de pesos a dólares se divide entre la tasa
            double montoDolares = montoPesos / TASA_USD;

            Console.WriteLine();
            Console.WriteLine($"Tasa del día: RD${TASA_USD:F2} por US$1");
            Console.WriteLine($"RD${montoPesos:F2} equivalen a US${montoDolares:F2}");
        }
    }
}
