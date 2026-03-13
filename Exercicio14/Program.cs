Console.WriteLine("=====================================================");
Console.WriteLine("Ordem Decrescente");
Console.WriteLine("=====================================================");
Console.WriteLine();


Console.Write("Digite o primeiro valor: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
int c = Convert.ToInt32(Console.ReadLine());


if (a == b || a == c || b == c)
{
  Console.Write("Não foi possível ordear os números pois existem números iguais.");
  return;
}


if (a < b)
{
  a = b;
}
if (a < c)
{
  a = c;
}

if (b > c)
{
  b = c;
}

Console.WriteLine($">> Ordem decrescente: {a}, {b}, {c}");