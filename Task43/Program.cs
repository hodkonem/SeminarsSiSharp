// Задача 43: Напишите программу, 
// которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetCoordinateX(int b1, int k1, int b2, int k2)
{
    double findX = (b2 - b1) / (k1 - k2);
    return Math.Round(findX, 1);
}

double GetCoordinateY(int b1, int k1, int b2, int k2, double x)
{
    double findY = (x * (k1 + k2) + b1 + b2) / 2;

    return Math.Round(findY, 1);
}
Console.WriteLine("Введите b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());

// надо найти x

if (b1 == b2 && k1 == k2) Console.WriteLine($"Прямые совпадают!");
else if (k1 == k2) Console.WriteLine($"Прямые паралельны!");
else
{
    double coordinateX = GetCoordinateX(b1, k1, b2, k2);
    double coordinateY = GetCoordinateY(b1, k1, b2, k2, coordinateX);
    Console.WriteLine($"Координаты точки пересечения ({coordinateX}, {coordinateY})");
}