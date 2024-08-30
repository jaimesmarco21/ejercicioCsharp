using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double suma = numero1 + numero2;
        double resta = numero1 - numero2;
        double multiplicacion = numero1 * numero2;
        double division = numero1 / numero2;

        Console.WriteLine($"\nSuma: {numero1} + {numero2} = {suma}");
        Console.WriteLine($"Resta: {numero1} - {numero2} = {resta}");
        Console.WriteLine($"Multiplicación: {numero1} * {numero2} = {multiplicacion}");
        Console.WriteLine($"División: {numero1} / {numero2} = {division}");
    }
}
