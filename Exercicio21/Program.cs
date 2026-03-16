Console.WriteLine("=====================================================");
Console.WriteLine("CÁLCULO FATORIAL");
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

int resultado = numero;

for (int i = numero - 1; i <= 1; i--)
{
  resultado = resultado * i;
}

Console.WriteLine(resultado);