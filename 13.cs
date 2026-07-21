using System;

class Program
{
    static void Main()
    {
        char resp;
        do
        {
            Console.Write("Ingrese la cantidad en moneda local: ");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nConversiones para {monto}:");
            Console.WriteLine($"- USD (Dólar EE.UU.): {monto * 0.13:F2}");
            Console.WriteLine($"- EUR (Euro): {monto * 0.12:F2}");
            Console.WriteLine($"- MXN (Peso Mexicano): {monto * 2.30:F2}");
            Console.WriteLine($"- JPY (Yen Japonés): {monto * 20.0:F2}");
            Console.WriteLine($"- GBP (Libra Esterlina): {monto * 0.10:F2}");

            Console.Write("\n¿Desea convertir otra cantidad? (s/n): ");
            resp = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine("\n");

        } while (resp == 's');
    }
}
