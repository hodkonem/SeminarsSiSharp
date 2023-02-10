// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRNDInt(int size, int min, int max) // Первое с чего начинаем - создаём метод создания и заполнения массива. Данный метод будет возвращать массив целых чисел.
{                                                   // Передаём параметры: размер (без магических чисел), диапазон: минимальное и максимальное значение.
    int[] array = new int[size]; // Сначала создаём массив, new int - это новый массив целочисленный, в скобках
    Random rnd = new Random(); // Экземпляр класса
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); // Вывести значения так, чтобы
        else Console.Write($"{array[i]}");                       // не было последней запятой
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

int GetSumNPositiveElem(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

int[] GetSumPositiveNegativeElem(int[] array) // В этом методе мы возвращаем массив
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            if (array[i] > 0) sumPositive += array[i];
            else sumNegative += array[i];
        }
    }
    return new int[] { sumPositive, sumNegative };
}

int[] arr = CreateArrayRNDInt(12, -9, 9);
PrintArray(arr);
// Теперь нужно вызвать методы, сначала для отрицательных чисел
int sumNegativeElem = GetSumNegativeElem(arr);
int sumPositiveElem = GetSumNPositiveElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}"); // Отработал певый метод
Console.WriteLine();
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}"); // Отработал второй (общий) метод
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");