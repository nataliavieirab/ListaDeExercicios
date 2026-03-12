Console.WriteLine("=====================================================");
Console.WriteLine("Calculo Média Harmônica!");
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.Write("Digite a quantidade de notas a serem calculadas: ");
int quantidadeNotas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

decimal soma = 0;
decimal nota;

for (int i = 1; i <= quantidadeNotas; i++)
{
  while (true)
  {
    Console.Write($"{i}- Digite a nota: ");
    nota = Convert.ToDecimal(Console.ReadLine());

    if (nota != 0)
      break;

    Console.WriteLine("Nota não pode ser zero.");
  }

  decimal inversoNota = 1 / nota;
  soma += inversoNota;
}

decimal mediaHarmonica = quantidadeNotas / soma;

Console.WriteLine();
Console.WriteLine($">> Média Harmônica: {mediaHarmonica:F2}");

Console.ReadLine();