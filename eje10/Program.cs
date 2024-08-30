using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de B: ");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine($"Valores originales: A = {A}, B = {B}");
        int temp = A;
        A = B;
        B = temp;
        Console.WriteLine($"Valores después del intercambio: A = {A}, B = {B}");
    }
}
