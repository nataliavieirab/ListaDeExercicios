Console.Write("Digite o salário base do vendedor: ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o total de vendas: ");
decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o percentual: ");
decimal percentual = Convert.ToDecimal(Console.ReadLine()) / 100;

decimal comissao = percentual * totalVendas;
decimal salarioTotal = salarioBase + comissao;

Console.WriteLine("-----------------------------------------------------");

Console.WriteLine($"Comissão: {comissao}");
Console.WriteLine($"Salário total do vendedor: {salarioTotal}");

Console.ReadLine();