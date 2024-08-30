using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de minutos: ");
        int minutosTotales = Convert.ToInt32(Console.ReadLine());

        int horas = minutosTotales / 60;
        int minutosRestantes = minutosTotales % 60;

        Console.WriteLine($"\n{minutosTotales} minutos son {horas} horas y {minutosRestantes} minutos.");
    }
}
