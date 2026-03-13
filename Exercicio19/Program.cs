Console.WriteLine("=====================================================");
Console.WriteLine("SOMA DE NUMEROS ÍMPARES MÚLTIPLOS DE 3 ENTRE 1 E 500");
Console.WriteLine("=====================================================");
Console.WriteLine();

int soma = 0;

for (int i = 1; i <= 500; i++)
{
  if (i % 2 != 0 && i % 3 == 0)
    soma += i;
}

Console.WriteLine($"Resultado:");
Console.WriteLine($">> {soma}");

Console.ReadLine();