// программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// e.g. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 

(double, double) GetCrossPointCoordinates(double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        Console.Write("Прямые не пересекаются. Значения k1 и k2 должны отличаться. ");
        Console.Write("Пожалуйста, измените значение k1 или k2.");
    }

double coordPointX;
double coordPointY;

coordPointX = (b2 - b1) / (k1 - k2);
coordPointY = k1*coordPointX + b1;

coordPointX = Math.Round(coordPointX, 1);
coordPointY = Math.Round(coordPointY, 1);

return (coordPointX, coordPointY);
}

Console.WriteLine("Введите значение k1:");
double inputK1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2:");
double inputK2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b1:");
double inputB1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2:");
double inputB2 = double.Parse(Console.ReadLine()!);

(double X, double Y) = GetCrossPointCoordinates(inputK1, inputK2, inputB1, inputB2);

Console.WriteLine($"Координаты точки пересечения двух прямых: {X}, {Y}");
