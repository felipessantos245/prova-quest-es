using System;

class Program
{
    static void Main()
    {
        Console.Write("Início: ");
        int inicio = int.Parse(Console.ReadLine());
        
        Console.Write("Fim: ");
        int fim = int.Parse(Console.ReadLine());

        Console.WriteLine("\n=== TABUADA ===");

        for (int i = inicio; i <= fim; i++)
        {
            Console.WriteLine($"\nTabuada do {i}:");
            
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }
}

