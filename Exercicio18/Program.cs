Console.WriteLine("=====================================================");
Console.WriteLine("Números Ímpares entre 100 e 200");
Console.WriteLine("=====================================================");
Console.WriteLine();

List<int> numerosImpares = [];

for (int i = 100; i <= 200; i++)
{
  if (i % 2 != 0)
  {
    numerosImpares.Add(i);
  }
  continue;
}

Console.WriteLine(string.Join(", ", numerosImpares));