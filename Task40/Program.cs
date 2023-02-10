// Задача 40
// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник
// со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух др

Console.WriteLine("Введите 1-ю сторону треугольника: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ю сторону треугольника: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ю сторону треугольника: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool TriangCompare(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
   
}
bool result = TriangCompare(number1, number2, number3);
Console.WriteLine(result ? "Да" : "Нет");