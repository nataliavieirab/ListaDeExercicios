Console.WriteLine("=====================================================");
Console.WriteLine("Calcular Valor Arrecadado");
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.Write("Digite a quantidade de pães vendidos: ");
int qtdPaes = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de broas vendidas: ");
int qtdBroas = Convert.ToInt32(Console.ReadLine());

decimal valorArrecadado = (qtdPaes * 0.12m) + qtdBroas * 1.50m;

decimal valorPoupanca = valorArrecadado * 0.10m;

Console.WriteLine();
Console.WriteLine($"O valor total arrecadado foi: R{valorArrecadado:C}");
Console.WriteLine($"Valor para poupança: R{valorPoupanca:C}");