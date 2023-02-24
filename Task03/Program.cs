// Задача 3
// Демонстрация решения

// Напишите программу, которая 
// 1. на вход выдает название дня недели по заданному номеру
// 2. вывод результата

// Например:
// 3 -> Среда
// 5 -> Пятница
// Если неправильный ввод, то мы должны ввывести пользователю сообщение "Error"

Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine()); // Преобразуем введенное значение в целочисленный тип данных 
if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}
else if (day == 3)
{
    Console.WriteLine("Среда");
}
else if (day == 4)
{
    Console.WriteLine("Четверг");
}
else if (day == 5)
{
    Console.WriteLine("Пятница");
}
else if (day == 6)
{
    Console.WriteLine("Суббота");
}
else if (day == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Error");
}
// Если пользователь ввёл что-то другое, то мы выводим какую-то ошибку. } 