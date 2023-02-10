// Задача 28: Напишите программу, которая
// принимает на вход число (А) и выдаёт произведение чисел
// от 1 до А.

int Factorial(int number)
{
    int result = 1;
    int counter = 1;
    while (counter <= number)
    {
        result *= counter;
        counter++;
    }
    return result;
}
Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0) Console.WriteLine("Некорректный ввод");
else
{
    int factorial = Factorial(num);
    Console.WriteLine($"{num} -> {factorial}");
}