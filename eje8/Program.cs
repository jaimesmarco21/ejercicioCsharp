using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        double raizCuadrada = Math.Sqrt(numero);
        double raizCubica = Math.Cbrt(numero);
        
        Console.WriteLine($"\nLa raíz cuadrada de {numero} es: {raizCuadrada}");
        Console.WriteLine($"La raíz cúbica de {numero} es: {raizCubica}");
    }
}
