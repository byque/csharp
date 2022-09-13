using System;
using System.Net;

namespace Interfaces
{
    /// <summary>
    /// Ejemplo del uso de interface
    /// Basado en:
    /// https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/interface
    /// </summary>
    interface IEjemploInterfaz
    {
        void EjemploMetodo();
    }

    interface IPunto
    {
        double X { get; set; }
        double Y { get; set; }

        double Distancia { get; }
    }

    class Punto : IPunto
    {
        // Constructor
        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Implementación de la propiedad
        public double X { get; set; }
        public double Y { get; set; }
        public double Distancia =>
            Math.Sqrt(X * X + Y * Y);
    }

    internal class ClaseImplementacion : IEjemploInterfaz
    {
        // Implementación explícita del miembro de la interfaz
        void IEjemploInterfaz.EjemploMetodo()
        {
            // Implementación del método
            Console.WriteLine("Método requerido por la interfaz");
        }

        static void ImprimirPunto(IPunto p)
        {
            Console.WriteLine("x={0}, y={1}, distancia={2}", p.X, p.Y, p.Distancia);
        }

        static void Main(string[] args)
        {
            // Declarar la instancia de la interfaz.
            IEjemploInterfaz objEjemplo = new ClaseImplementacion();

            // Llamar al miembro
            objEjemplo.EjemploMetodo();

            IPunto p = new Punto(0.5, 1.75);
            Console.Write("Mi punto: ");
            ImprimirPunto(p);
        }
    }
}
