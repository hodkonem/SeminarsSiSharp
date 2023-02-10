/* Задача 8
0. Демонстрация решения

Напишите программу, 
1. которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
2. вывод результата

Например:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string firstNumber = "";
int localNumber = number % 2 == 0 ? number : number - 1;
if (localNumber >= 1)
{
    for (int i = 2; i <= localNumber; i += 2)
    {
        firstNumber += Convert.ToString(i);
        if (i != localNumber)
        {
            firstNumber += ",";
        }
    }
    Console.WriteLine($"{firstNumber}");
}
else
{
    Console.WriteLine("Вы ввели отрицательное число. Введите положительное число больше 1: ");
}