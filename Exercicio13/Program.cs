Console.WriteLine("======================================");
Console.WriteLine("VERIFICAÇÃO: A + B É MENOR QUE C?");
Console.WriteLine("======================================");
Console.WriteLine();

Console.Write("Digite o valor de A: ");
decimal valorA = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o valor de B: ");
decimal valorB = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o valor de C: ");
decimal valorC = Convert.ToDecimal(Console.ReadLine());

decimal soma = valorA + valorB;

Console.WriteLine();

if (soma < valorC)
{
  Console.WriteLine($">> A soma de {valorA} + {valorB} = {soma}");
  Console.WriteLine($"Resultado: {soma} é MENOR que {valorC}");
}
else
{
  Console.WriteLine($">> A soma de {valorA} + {valorB} = {soma}");
  Console.WriteLine($"Resultado: {soma} NÃO é menor que {valorC}");
}

Console.ReadLine();