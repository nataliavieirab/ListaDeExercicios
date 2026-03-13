Console.WriteLine("=====================================================");
Console.WriteLine("CÁLCULO DE SALÁRIO (AUMENTO E DESCONTO DE IMPOSTO)");
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.Write("Digite o salário do funcionário: ");
decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

decimal salarioComAumento = salarioInicial + (salarioInicial * 0.15m);
decimal valorImposto = salarioComAumento * 0.08m;
decimal salarioFinal = salarioComAumento - valorImposto;

Console.WriteLine();
Console.WriteLine("--------------- RESULTADO ----------------");
Console.WriteLine($"Salário inicial: R$ {salarioInicial}");
Console.WriteLine($"Salário com aumento de 15%: R$ {salarioComAumento}");
Console.WriteLine($"Salário final após desconto de 8%: R$ {salarioFinal:F2}");
Console.WriteLine("------------------------------------------");
