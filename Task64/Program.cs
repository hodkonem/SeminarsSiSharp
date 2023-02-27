// Задача 64: Задайте значение N. 
// 1. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. 
// 2. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NaturalNumbers(int num)
{
    // Base case: when num is 1, return it as a string
    if (num == 1)
    {
        return "1";
    }
    // Recursive case: return the current number and the result of the function with num-1
    return $"{num}, {NaturalNumbers(num - 1)}";
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number <= 0)
{
    Console.WriteLine("Вы ввели неправильное значение! Введите число больше, чем 0: ");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"N = {number} -> \"{NaturalNumbers(number)}\"");