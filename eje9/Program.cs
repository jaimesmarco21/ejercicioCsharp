using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número de dos cifras: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 10 && numero <= 99)
        {
            int decenas = numero / 10; 
            int unidades = numero % 10; 

            int numeroInvertido = (unidades * 10) + decenas;
            Console.WriteLine($"\nEl número invertido de {numero} es: {numeroInvertido}");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número de dos cifras.");
        }
    }
}
