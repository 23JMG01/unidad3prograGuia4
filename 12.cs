using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese grados Centígrados (°C): ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("a. Fahrenheit\nb. Celsius\nc. Kelvin");
        Console.Write("Opción: ");
        char op = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (op)
        {
            case 'a': Console.WriteLine($"{c} °C = {(c * 9 / 5) + 32} °F"); break;
            case 'b': Console.WriteLine($"{c} °C = {c} °C"); break;
            case 'c': Console.WriteLine($"{c} °C = {c + 273.15} K"); break;
            default: Console.WriteLine("Opción no válida."); break;
        }
    }
}
