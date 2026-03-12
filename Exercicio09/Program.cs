Console.WriteLine("=====================================================");
Console.WriteLine("Calcular Área de um Retângulo!");
Console.WriteLine("=====================================================");
Console.WriteLine();

decimal comprimento, largura, area;

Console.Write("Digite o valor do comprimento: ");
comprimento = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o valor da largura: ");
largura = Convert.ToDecimal(Console.ReadLine());

area = comprimento * largura;

Console.WriteLine();
Console.WriteLine($">> A área do terreno é: {area} m²");

Console.ReadLine();