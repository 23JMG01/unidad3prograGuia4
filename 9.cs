using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        char[] caracteres = frase.ToCharArray();
        Array.Reverse(caracteres);
        string invertida = new string(caracteres);

        Console.WriteLine($"Frase invertida: {invertida}");
    }
}
