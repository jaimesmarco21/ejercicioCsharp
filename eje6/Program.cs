using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el monto total de la compra: ");
        double montoCompra = Convert.ToDouble(Console.ReadLine());

        double descuento = montoCompra * 0.15;
        double montoFinal = montoCompra - descuento;
        
        Console.WriteLine($"\nDescuento aplicado: {descuento:C}");
        Console.WriteLine($"Monto final a pagar: {montoFinal:C}");
    }
}

