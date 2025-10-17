double n1 = 0, p1 = 0;
double n2 = 0, p2 = 0;
double n3 = 0, p3 = 0;
double valor;

Console.WriteLine("Digite a 1° nota");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro peso");
p1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 2° nota");
n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo peso");
p2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 3° nota");
n3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro peso");
p3 = double.Parse(Console.ReadLine());

valor = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);

Console.WriteLine($"Certo a média ponderada é {valor:F2}");

    if (valor >= 7)
{

    Console.WriteLine("Aprovado");
}
if (valor == 6)
{

    Console.WriteLine("Média");
}

if (valor <= 5)
{

    Console.WriteLine("Reprovado");
}
