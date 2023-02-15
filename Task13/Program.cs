// Задача 13. Напишите программу, которая
// 1. выводит третью цифру заданного числа или
// 2. сообщает, что третьей цифры нет.

int GetThirdNumber(int num)
{
    if (num < 100) return -1;
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number < 0 ? GetThirdNumber(-number) : GetThirdNumber(number);
Console.WriteLine(result == -1 ? $"В числе {number} третьей цифры нет." : $"Третья цифра в числе {number} -> {result}");