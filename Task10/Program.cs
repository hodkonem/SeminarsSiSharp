/* Задача №10 Напишите программу, которая принимает
на вход трёхзначное число и на выходе
показывает вторую цифру этого числа.
*/

int GetNumber(int num)  // начало метода
{
    return num / 10 % 10;
}                       // конец метода

Console.WriteLine("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number > 999)       // начало цикла
{
    Console.WriteLine("Вы ввели неправильное число! Введите целое трёхзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}                                          // конец цикла

int result = GetNumber(number);     // вызов метода
Console.WriteLine($"{number} -> {result}");