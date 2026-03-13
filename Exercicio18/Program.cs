Console.WriteLine("=====================================================");
Console.WriteLine("NÚMEROS ÍMPARES ENTRE 100 E 200");
Console.WriteLine("=====================================================");
Console.WriteLine();

for (int i = 100; i <= 200; i++)
{
  if (i % 2 != 0)
    Console.Write($"{i} - ");
}

Console.WriteLine();
Console.ReadLine();