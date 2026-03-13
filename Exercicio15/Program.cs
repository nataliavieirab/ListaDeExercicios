Console.WriteLine("=====================================================");
Console.WriteLine("Calcular IMC");
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.Write("Digite seu peso em kg: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura em metros (ex: 1.75): ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
{
  Console.WriteLine($"O IMC foi: {imc:F2}. Considerado abaixo do peso!");
}
else if (imc >= 18.5 && imc <= 25)
{
  Console.WriteLine($"O IMC foi: {imc:F2}. Considerado peso normal!");
}
else if (imc > 25 && imc <= 30)
{
  Console.WriteLine($"O IMC foi: {imc:F2}. Considerado sobrepeso!");
}
else
{
  Console.WriteLine($"O IMC foi: {imc:F2}. Considerado obesidade!");
}

Console.ReadLine();