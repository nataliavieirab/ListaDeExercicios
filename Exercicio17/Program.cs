int a, b, c;
string operacao;

Console.Write("Digite o primeiro valor: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
  c = a + b;
  operacao = "soma";
}
else
{
  c = a * b;
  operacao = "multiplicação";
}

Console.WriteLine($"O resultado da {operacao} dos valores é {c}");

Console.ReadLine();