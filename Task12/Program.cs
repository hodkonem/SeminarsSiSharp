// 12. Напишите программу, 

// 1. которая будет принимать на вход два числа и выводить, 
// 2. является ли первое число кратным второму. 
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// Пример:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int MultipleNum(int num1, int num2)
{
    return num1 % num2;
}

Console.WriteLine("Введите два числа :");

int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());

int remains = MultipleNum(numberFirst, numberSecond);

if (remains == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, {remains} ");
}