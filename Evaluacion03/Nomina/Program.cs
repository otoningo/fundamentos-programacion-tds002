using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 06/11/2026
Descripción: calcula el salario bruto, los descuentos de AFP y SFS y el salario neto
de un empleado a partir de las horas trabajadas y el pago por hora.
 */

namespace Nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // porcentajes que se le descuentan al empleado
            const double PORCENTAJE_AFP = 0.0287;
            const double PORCENTAJE_SFS = 0.0304;

            // entrada
            Console.Write("Nombre del empleado: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Horas trabajadas: ");
            double horas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Pago por hora (RD$): ");
            double pagoHora = Convert.ToDouble(Console.ReadLine());

            // proceso
            double salarioBruto = horas * pagoHora;
            double afp = salarioBruto * PORCENTAJE_AFP;
            double sfs = salarioBruto * PORCENTAJE_SFS;
            double salarioNeto = salarioBruto - afp - sfs;

            // salida
            Console.WriteLine();
            Console.WriteLine("========== NÓMINA ==========");
            Console.WriteLine($"Empleado: {nombre.ToUpper()}");
            Console.WriteLine($"Salario bruto: {salarioBruto,12:N2}");
            Console.WriteLine($"AFP (2.87 %):  {afp,12:N2}");
            Console.WriteLine($"SFS (3.04 %):  {sfs,12:N2}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Salario neto:  {salarioNeto,12:N2}");
        }
    }
}
