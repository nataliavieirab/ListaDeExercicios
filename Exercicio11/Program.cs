Console.WriteLine("=====================================================");
Console.WriteLine("Quantos dias você já viveu?");
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

int diasDeVida = idade * 365;

Console.WriteLine();
Console.WriteLine($"{nome!.ToUpper()}, VOCÊ JÁ VIVEU {diasDeVida} DIAS! :)");

Console.ReadLine();