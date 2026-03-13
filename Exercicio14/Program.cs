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
  Console.WriteLine("Não foi possível ordenar os números pois existem números iguais.");
  return;
}

int temp;

if (a < b)
{
  temp = a;
  a = b;
  b = temp;
}

if (a < c)
{
  temp = a;
  a = c;
  c = temp;
}

if (b < c)
{
  temp = b;
  b = c;
  c = temp;
}

Console.WriteLine($">> Ordem decrescente: {a}, {b}, {c}");