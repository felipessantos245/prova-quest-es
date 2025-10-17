using System;

class Program
{
    static void Main()
    {
        int a = 0, b = 0, c = 0, nulos = 0;

        Console.WriteLine("Sistema de Votação\n1: Candidato A\n2: Candidato B\n3: Candidato C\n9: Nulo\n0: Sair\n");

        while (true)
        {
            Console.Write("Voto: ");
            int voto = Convert.ToInt32(Console.ReadLine());

            if (voto == 0) break;

            switch (voto)
            {
                case 1: a++; break;
                case 2: b++; break;
                case 3: c++; break;
                case 9: nulos++; break;
                default: Console.WriteLine("Inválido!"); break;
            }
        }

        Console.WriteLine($"\nResultado:\nCandidato A: {a}\nCandidato B: {b}\nCandidato C: {c}\nNulos: {nulos}");
    }
}