// Задача 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// 12 мин

int number = new Random().Next(100, 999);
Console.WriteLine($"Трехзначное число {number}");
int RemoveTheSecond(int num)
{
    int numberFirst = num / 100; // 4.56 4
    int numberThird = num % 10;
    int numberResult = numberFirst * 10 + numberThird;
    return numberResult;
}
Console.WriteLine(RemoveTheSecond(number));