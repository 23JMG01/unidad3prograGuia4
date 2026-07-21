using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] opciones = { "Piedra", "Papel", "Tijeras" };
        char jugar;

        do
        {
            Console.WriteLine("\n--- Juego: Piedra, Papel o Tijeras ---");
            Console.WriteLine("1. Piedra\n2. Papel\n3. Tijeras");
            Console.Write("Elige tu opción (1-3): ");
            int usuario = int.Parse(Console.ReadLine()) - 1;

            int comp = random.Next(0, 3);

            Console.WriteLine($"\nTú elegiste: {opciones[usuario]}");
            Console.WriteLine($"La computadora eligió: {opciones[comp]}");

            if (usuario == comp)
            {
                Console.WriteLine("¡Resultado: Empate!");
            }
            else if ((usuario == 0 && comp == 2) || (usuario == 1 && comp == 0) || (usuario == 2 && comp == 1))
            {
                Console.WriteLine("¡Resultado: Ganaste!");
            }
            else
            {
                Console.WriteLine("¡Resultado: Gana la computadora!");
            }

            Console.Write("\n¿Deseas jugar de nuevo? (s/n): ");
            jugar = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

        } while (jugar == 's');
    }
}
