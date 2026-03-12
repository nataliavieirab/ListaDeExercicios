Console.WriteLine("=====================================================");
Console.WriteLine("Calculo Média Ponderada!");
Console.WriteLine("=====================================================");
Console.WriteLine();

decimal nota1, nota2, peso1, peso2, somaPesos, mediaPonderada;

Console.WriteLine(">> Primeira Nota");

Console.Write("Digite a nota: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o peso: ");
peso1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();
Console.WriteLine(">> Segunda Nota ");

Console.Write("Digite a nota da segunda prova: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o peso: ");
peso2 = Convert.ToDecimal(Console.ReadLine());

somaPesos = peso1 + peso2;
mediaPonderada = (nota1 * peso1 + nota2 * peso2) / somaPesos;

Console.WriteLine();
Console.Write($">> Média Ponderada:{mediaPonderada:F2}");

Console.ReadLine();