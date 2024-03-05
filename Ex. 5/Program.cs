int[] vet1 = new int[5];
int[] vet2 = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º valor para o vetor Vet1: ");
    vet1[i] = int.Parse(Console.ReadLine());
    Console.Write($"Digite o {i + 1}º valor para o vetor Vet2: ");
    vet2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Resultados: ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Elemento {i + 1}:");
    Console.WriteLine($"Soma: {vet1[i] + vet2[i]}");
    Console.WriteLine($"Diferença: {vet1[i] - vet2[i]}");
    Console.WriteLine($"Produto: {vet1[i] * vet2[i]}");
    if (vet2[i] != 0)
    {
        Console.WriteLine($"Divisão: {(double)vet1[i] / vet2[i]}");
    }
    else
    {
        Console.WriteLine("Divisão por zero não é possível.");
    }
}