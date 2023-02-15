// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("введите координаты первой точки ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distanceRound}");


double Distance(int xc1, int yc1, int xc2, int yc2)
{
    return Math.Sqrt(Math.Pow((xc2 - xc1), 2) + Math.Pow((yc2 - yc1), 2));
}



// Console.WriteLine("Введите координаты A1: ");
// Console.Write("x1: ");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y1: ");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты A2: ");
// Console.Write("x2: ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y2: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// double Distance(double xa,double ya,double xb,double yb)
// {
//     return  Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb));
// }
// double distance = Distance(x1,y1,x2,y2);
// Console.WriteLine(Math.Round(distance,2,MidpointRounding.ToZero));