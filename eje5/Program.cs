using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el salario base del vendedor: ");
        double salarioBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el monto total de ventas del vendedor: ");
        double montoVentas = Convert.ToDouble(Console.ReadLine());

        double comision = montoVentas * 0.10;
        double salarioTotal = salarioBase + comision;

        Console.WriteLine($"\nComisión: {comision:C}");
        Console.WriteLine($"Salario total a recibir: {salarioTotal:C}");
    }
}

