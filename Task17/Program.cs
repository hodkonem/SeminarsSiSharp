bool MultipleNum(int num1)
{
    return num1 % 7 == 0 && num1 % 23 == 0;
}

Console.WriteLine("Введите число :");

int number = Convert.ToInt32(Console.ReadLine());
bool remains = MultipleNum(number);

if (remains == true)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}