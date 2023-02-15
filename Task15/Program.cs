// Задача 15. Напишите задачу, которая
// 1. принимает на вход цифру, обозначающую
// 2. день недели, и проверяет, является ли
// 3. этот день выходным.

bool GetWeekEnd(int num)
{
    return num == 6 || num == 7;
}

Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1 || number > 7)
{
    Console.Write("Вы ввели неправильный порядковый номер! Введите число от 1 до 7: ");
    number = Convert.ToInt32(Console.ReadLine());
}

bool res = GetWeekEnd(number); // вызов метода
Console.WriteLine(res ? "является выходным днём" : "не является выходным днём");