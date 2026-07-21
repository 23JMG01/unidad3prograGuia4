using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el lado 1: ");
        double l1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el lado 2: ");
        double l2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el lado 3: ");
        double l3 = double.Parse(Console.ReadLine());

        if (l1 == l2 && l2 == l3)
        {
            Console.WriteLine("El triángulo es Equilátero.");
        }
        else if (l1 == l2 || l1 == l3 || l2 == l3)
        {
            Console.WriteLine("El triángulo es Isósceles.");
        }
        else
        {
            Console.WriteLine("El triángulo es Escaleno.");
        }
    }
}
