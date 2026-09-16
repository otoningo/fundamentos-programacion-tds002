using System;

/*
Nombre: Joycel Otoniel Pérez Nieves
Fecha: 16/09/2026
Descripción: programa de consola en C# que imprima mi tarjeta de presentación: nombre, matrícula, carrera y una frase que me describe, con un marco hecho de caracteres (*, =, |)
 */

// comentario1
// comentario2
// comentario3
namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Joycel Otoniel Pérez Nieves";
            string matricula = "2026-0703";
            string carrera = "Tecnólogo en Ciberseguridad";
            string frase = "Make Money Not Friends";

            int ancho = 55;

            Console.WriteLine(new string('*', ancho));
            Console.WriteLine("|" + new string('=', ancho - 2) + "|");
            Console.WriteLine("|" + Centrar("PRESENTACIÓN", ancho - 2) + "|");
            Console.WriteLine("|" + new string('=', ancho - 2) + "|");

            Console.WriteLine("|" + Centrar($"Nombre: {nombre}", ancho - 2) + "|");
            Console.WriteLine("|" + Centrar($"Matrícula: {matricula}", ancho - 2) + "|");
            Console.WriteLine("|" + Centrar($"Carrera: {carrera}", ancho - 2) + "|");
            Console.WriteLine("|" + new string('-', ancho - 2) + "|");
            Console.WriteLine("|" + Centrar(frase, ancho - 2) + "|");

            Console.WriteLine(new string('*', ancho));
        }

        static string Centrar(string texto, int ancho)
        {
            if (texto.Length >= ancho) return texto.Substring(0, ancho);
            int espacios = ancho - texto.Length;
            int izquierda = espacios / 2;
            return new string(' ', izquierda) + texto + new string(' ', espacios - izquierda);
        }
    }
}
