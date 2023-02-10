/* Задача 4
0. Демонстрация решения

1. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
3. Вывод результата.

Например:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: "); // показываем пользователю, что надо ввести первое число
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: "); // показываем пользователю, что надо ввести второе число
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: "); // показываем пользователю, что надо ввести третье число
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine($"Максимальное число: {firstNumber}");
    }
    else
    {
        Console.WriteLine($"Максимальное число: {thirdNumber}");
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine($"Максимальное число: {secondNumber}");
}
else
{
    Console.WriteLine($"Максимальное число: {thirdNumber}");
}