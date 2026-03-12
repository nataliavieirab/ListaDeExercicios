Console.Write("Digite a temperatura em Celsius: ");
decimal celsius = Convert.ToDecimal(Console.ReadLine());

decimal fahrenheit = (9m / 5m * celsius) + 32;

Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

Console.ReadLine();