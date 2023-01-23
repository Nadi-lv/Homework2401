double s (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return result; 
}

Console.WriteLine("Программа для вычисления расстояния между точками");
Console.WriteLine("Введите координату Х1:");
if (!int.TryParse (Console.ReadLine(), out var x1))
    Console.WriteLine("Введено не целое число");

Console.WriteLine("Введите координату У1:");
if (!int.TryParse (Console.ReadLine(), out var y1))
    Console.WriteLine("Введено не целое число");

Console.WriteLine("Введите координату Z1:");
if (!int.TryParse (Console.ReadLine(), out var z1))
    Console.WriteLine("Введено не целое число");


Console.WriteLine("Введите координату Х2:");
if (!int.TryParse (Console.ReadLine(), out var x2))
    Console.WriteLine("Введено не целое число");

Console.WriteLine("Введите координату У2:");
if (!int.TryParse (Console.ReadLine(), out var y2))
    Console.WriteLine("Введено не целое число");


Console.WriteLine("Введите координату Z2:");
if (!int.TryParse (Console.ReadLine(), out var z2))
    Console.WriteLine("Введено не целое число");
var rasst = s(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"расстояние между двумя точками - {rasst}");    



