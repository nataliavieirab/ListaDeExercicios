Console.Write("Digite a quilometragem inicial do veículo: ");
decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quilometragem final do veículo: ");
decimal kmFinal = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quantidade de combustível consumida (litros): ");
decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

decimal distanciaPercorrida = kmFinal - kmInicial;

decimal consumoLitrosPorKm = distanciaPercorrida / combustivelConsumido;

Console.WriteLine($"O consumo de combústivel durante o percurso foi de ~: {consumoLitrosPorKm} km/l");

Console.ReadLine();