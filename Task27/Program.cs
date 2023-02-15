// Задача 27: Напишите программу, 
// которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumNumbers (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int enteredNumber = Convert.ToInt32(Console.ReadLine());

if (enteredNumber > -10 && enteredNumber < 10)
{
    Console.WriteLine($"Вы ввели цифру {enteredNumber}, а не число!");
}
else
{
int result = enteredNumber < 0 ? GetSumNumbers(-enteredNumber) : GetSumNumbers(enteredNumber);
Console.WriteLine($"Сумма цифр числа {enteredNumber}: {result}.");
}