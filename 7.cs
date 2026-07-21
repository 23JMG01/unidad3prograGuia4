using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        Console.WriteLine("=== Registro de 10 contactos ===");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            nombres[i] = Console.ReadLine();
            Console.Write($"Teléfono {i + 1}: ");
            telefonos[i] = Console.ReadLine();
        }

        Console.Write("\nIngrese la posición a consultar (1 al 10): ");
        int pos = int.Parse(Console.ReadLine());

        if (pos >= 1 && pos <= 10)
        {
            Console.WriteLine($"\nContacto {pos}: {nombres[pos - 1]} - Tel: {telefonos[pos - 1]}");
        }
        else
        {
            Console.WriteLine("Posición no válida.");
        }
    }
}
