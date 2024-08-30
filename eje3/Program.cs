using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        double media = (numero1 + numero2 + numero3) / 3;

        Console.WriteLine($"\nLa media de {numero1}, {numero2} y {numero3} es: {media}");
    }
}
