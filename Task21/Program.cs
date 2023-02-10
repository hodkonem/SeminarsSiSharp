/* Задача 21
Напишите программу, которая 
1. принимает на вход координаты двух точек и 
2. находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetCoordinates(int ax, int ay, int az, int bx, int by, int bz)
{
    double res = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
    return Math.Round(res, 2);
}
/*
Math.Sqrt() – математическая функция, которая извлекает квадратный корень. 
В аргументных скобках указывается значение числа, из которого нужно извлечь квадратный корень.

Math.Pow() – возведения числа в степень. В аргументных скобках через запятую указываются два аргумента 
(1-ый аргумент - число, которое возводим в степень, 2-ой – степень, в которую возводим число).
*/
Console.WriteLine("Введите координаты первой точки ");
Console.Write("AX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("AY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("AZ: ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
Console.Write("BX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("BY: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("BZ: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double result = GetCoordinates(aX, aY, aZ, bX, bY, bZ);
Console.WriteLine(result);