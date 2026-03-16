Console.WriteLine("=====================================================");
Console.WriteLine("SEQUÊNCIA DE FIBONACCI");
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int anterior = 0;
int atual = 1;

Console.Write(anterior);

if (numero > 1)
{
  Console.Write(", " + atual);
}

for (int i = 2; i < numero; i++)
{
  int proximo = anterior + atual;

  Console.Write(", " + proximo);

  anterior = atual;
  atual = proximo;
}

Console.WriteLine();

Console.ReadLine();