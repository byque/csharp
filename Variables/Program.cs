namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos primitivos de variables. Ver el explorador de objetos con
            // Ctrl + Alt + J 

            bool esIgual = true;
            byte poco = 127;
            char caracter = 'A';
            // Los números reales se tratan como double por defecto.
            double mayorPrecision = 20.957;
            float menorPrecision = 20.95F;
            int contador = 15;

            // C# permite declarar variables para ser definidas por el
            // compilador, pero usa los tipos primitivos de variables por
            // defecto.
            var num = 3;  // Int32
            var pi = 3.1416;  // Double
            
            // Escribir c + w + tab + tab como atajo para la función de
            // escritura en la consola.
            Console.WriteLine( esIgual );
            Console.WriteLine( poco );
            Console.WriteLine( caracter );
            Console.WriteLine( mayorPrecision );
            Console.WriteLine( menorPrecision );
            Console.WriteLine( contador );        
            Console.WriteLine( num );
            Console.WriteLine( pi );

            // Especificar marcadores de posición en una cadena con formato.
            Console.WriteLine();
            Console.WriteLine("Byte");
            Console.WriteLine("Valor máximo = {0}, valor mínimo = {1}",
                              byte.MaxValue, byte.MinValue);
        }
    }
}
