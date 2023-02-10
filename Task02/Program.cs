/* Задача 2
0. Демонстрация решения

1. Написать программу, которая на вход принимает два числа и
2. выдает, какое число большее, а какое меньшее.
3. Вывод результата.

Например:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число 1: "); // показываем пользователю, что надо ввести первое число
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: "); // показываем пользователю, что надо ввести второе число
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine($"max = {firstNumber}, min = {secondNumber}");
}
else
{
    Console.WriteLine($"max = {secondNumber}, min = {firstNumber}");
}