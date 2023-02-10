// 1. ввод или генерирование
// 2. проверка по условию
// 3. выполнение задачи по условию
// 4. вывод
// Задача 25: Напишите цикл, 
// который принимает на вход два числа (А и В) и
// возводит число А в натуральную степень
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetResult(double num, double deg)
{
    double res = num;
    for (int i = 1; i < deg; i++)
    {
        res *= num;
    }
    return res;
}

Console.Write("Введите первое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите положительное число - степень: ");
string? degree = Console.ReadLine();

int numberOfDegree;
bool res = int.TryParse(degree, out numberOfDegree);

while (numberOfDegree <= 0 || !res)
{
    Console.Write("Степень должна быть натуральным числом.Введите, пожалуйста, положительное целое число: ");
    degree = Console.ReadLine();
    res = int.TryParse(degree, out numberOfDegree);
}

double result = GetResult(firstNumber, numberOfDegree);
Console.WriteLine($"{firstNumber} в степени {numberOfDegree}: {result}.");