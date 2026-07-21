using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad en metros: ");
        double metros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Seleccione la opción a convertir:");
        Console.WriteLine("a. Milímetros\nb. Centímetros\nc. Decímetros\nd. Hectómetros\ne. Kilómetros");
        Console.Write("Opción: ");
        char opcion = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        double resultado = 0;
        string unidad = "";

        switch (opcion)
        {
            case 'a': resultado = metros * 1000; unidad = "milímetros"; break;
            case 'b': resultado = metros * 100; unidad = "centímetros"; break;
            case 'c': resultado = metros * 10; unidad = "decímetros"; break;
            case 'd': resultado = metros / 100; unidad = "hectómetros"; break;
            case 'e': resultado = metros / 1000; unidad = "kilómetros"; break;
            default: Console.WriteLine("Opción no válida."); return;
        }

        Console.WriteLine($"{metros} metros equivale a {resultado} {unidad}.");
    }
}
