using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese peso en kg: ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Ingrese altura en metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine($"Su IMC es: {imc:F2}");
    }
}
