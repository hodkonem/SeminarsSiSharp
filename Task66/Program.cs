// Задача 66: Задайте значения M и N. 
// 1. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// 2. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
// Этот код написан для нахождения суммы натуральных чисел между двумя введенными пользователем числами (m и n). 
Функция NaturalNumbers() принимает два целых числа (m и n) в качестве аргументов и возвращает сумму всех натуральных чисел от m до n. 
Базовый случай - это когда m и n равны, и в этом случае функция возвращает m. 
Функция также обрабатывает, если m больше n, в этом случае она рекурсивно вызовет функцию NaturalNumbers() с m-1 и n в качестве 
параметров, или если m меньше n, в этом случае она рекурсивно вызовет функцию NaturalNumbers() с m+ 1 и n в качестве параметров. 
Код также запрашивает два введенных пользователем натуральных числа, которые хранятся в numberOne и numberTwo, и выполняет цикл, 
чтобы убедиться, что пользователь вводит только натуральные числа. Наконец, результат вычисления натуральных чисел между введенными 
пользователем числами сохраняется в переменной result и отображается на консоли.
*/

int NaturalNumbers(int m, int n) // Recursive method to find the sum of natural numbers between m and n
{
    if (m == n) return m; // Base case: if m and n are equal, return m
    if (m > n)
    {
        return m + NaturalNumbers(m - 1, n);
    }
    else
    {
        return m + NaturalNumbers(m + 1, n);
    }
}

Console.Write("Введите первое натуральное число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

while (numberOne <= 0 || numberTwo <= 0)
{
    Console.WriteLine("Вы ввели неверное число!");

    Console.Write("Введите первое натуральное число: ");
    numberOne = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе натуральное число: ");
    numberTwo = Convert.ToInt32(Console.ReadLine());
}

int result = NaturalNumbers(numberOne, numberTwo);
Console.WriteLine(result);