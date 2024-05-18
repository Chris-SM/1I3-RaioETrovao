double Dis;

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("-----Calcular a Distancia entre VOCÊ e o RAIO-----");
Console.ResetColor();

Console.Write("\n\nDigite o tempo (em segundo) que demorou para ouvir o raio depois de vê-lo: ");
int Tempo = Convert.ToInt32(Console.ReadLine());
Dis = CalcDist(Tempo);

Console.WriteLine("Hum\nTempo | Distancia");
Console.WriteLine($" {Tempo:D2} S |  {Dis:N4} KM");

double CalcDist(double Tempo)
{
    double dis;
    dis = (340.29 * Tempo) / 1000;
    return dis;
}