Console.WriteLine("=====================================================");
Console.WriteLine("FIZZ, BUZZ e FIZZBUZZ");
Console.WriteLine("=====================================================");
Console.WriteLine();

for (int i = 1; i <= 100; i++)
{
  string resultado = "";

  if (i % 3 == 0) resultado += "Fizz";
  if (i % 5 == 0) resultado += "Buzz";

  Console.Write($"{(resultado == "" ? i : resultado)}, ");
}