using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto: ");
        int precio = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la denominación dada por el cliente: ");
        int pago = int.Parse(Console.ReadLine());

        int cambio = pago - precio;

        if (cambio < 0)
        {
            Console.WriteLine("Monto insuficiente.");
            return;
        }

        Console.WriteLine($"\nCambio total: {cambio}");

        int b200 = cambio / 200; cambio %= 200;
        int b100 = cambio / 100; cambio %= 100;
        int b50 = cambio / 50;   cambio %= 50;
        int b20 = cambio / 20;   cambio %= 20;
        int monedas = cambio;

        Console.WriteLine($"Billetes de 200: {b200}");
        Console.WriteLine($"Billetes de 100: {b100}");
        Console.WriteLine($"Billetes de 50: {b50}");
        Console.WriteLine($"Billetes de 20: {b20}");
        Console.WriteLine($"Monedas: {monedas}");
    }
}
