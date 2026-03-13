Console.WriteLine("=====================================================");
Console.WriteLine("Par ou Ímpar");
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
  Console.WriteLine($">> O número {numero} é par");
  Console.ReadLine();
  return;
}

Console.WriteLine($">> O número {numero} é ímpar");

Console.ReadLine();