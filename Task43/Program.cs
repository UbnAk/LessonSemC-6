// Напишите программу, которая найдёт точку пересечения двух
// прямых, заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
//пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double ReadInt(string arg)
{
    System.Console.WriteLine(arg);
    return double.Parse(Console.ReadLine());
}

void FindIntersectionPoint (double k1, double b1, double k2, double b2)
{
    double x = ((b2-b1)/(k1-k2));
    double y = k1*x + b1;
    System.Console.WriteLine($"Точка пересечения двух прямых заданных уравнениями y = k1 * x + b1,");
    System.Console.WriteLine($"y = k2 * x + b2 равна ({x};{y})");
}
double b1 = ReadInt($"Введите значение b1: ");
double k1 = ReadInt($"Введите значение k1: ");
double b2 = ReadInt($"Введите значение b2: ");
double k2 = ReadInt($"Введите значение k2: ");
FindIntersectionPoint(k1,b1,k2,b2);