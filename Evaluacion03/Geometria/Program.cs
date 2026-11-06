using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: calcula el área y la circunferencia de un círculo y la hipotenusa de un
triángulo rectángulo usando la clase Math.
 */

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            // entrada
            Console.Write("Radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cateto a del triángulo: ");
            double catetoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cateto b del triángulo: ");
            double catetoB = Convert.ToDouble(Console.ReadLine());

            // proceso
            double area = Math.PI * Math.Pow(radio, 2);
            double circunferencia = 2 * Math.PI * radio;
            // teorema de Pitágoras: la hipotenusa es la raíz de a² + b²
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

            // salida
            Console.WriteLine();
            Console.WriteLine("===== CÍRCULO =====");
            Console.WriteLine($"Área: {area:F2}");
            Console.WriteLine($"Circunferencia: {circunferencia:F2}");
            Console.WriteLine();
            Console.WriteLine("===== TRIÁNGULO RECTÁNGULO =====");
            Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
        }
    }
}
