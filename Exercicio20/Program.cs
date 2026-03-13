Console.WriteLine();
Console.Write("Digite o número da tabuada que você quer gerar: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"=============== TABUADA do {numero} ===============");
Console.WriteLine();

for (int i = 0; i <= 10; i++)
{
  int resultado = i * numero;
  Console.WriteLine($"{numero} x {i} = {resultado}");
  Console.WriteLine();
}

Console.ReadLine();