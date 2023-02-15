// Задача 38: 
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементом массива.

// Пример:
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateDoubleArray(int length, int min, int max) // Первое с чего начинаем - создаём метод создания и заполнения массива. Данный метод будет возвращать массив вещественных чисел.
{                                                   // Передаём параметры: размер (без магических чисел), диапазон: минимальное и максимальное значение.
    double[] array = new double[length]; // Сначала создаём массив, new double - это новый массив вещественный, в скобках параметр.
    Random rnd = new Random(); // Экземпляр класса
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (min - max) + min, 1); // NextDouble не принимает параметры, он возвращает значение от нуля до единицы.
    }
    return array;
}

// Функция вывода массива
string PrintArray(double[] arr)
{
    string str = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (str == "[") str += arr[i];
        else str += $", {arr[i]}";
    }
    str += "]";
    return str;
}

// Метод, который получает максимальное число массива. Создаём переменную, в которую кладём результат выполнения метода.
// Аргументы мы записываем без указания типа переменной, а параметры с указанием.
double GetMaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

// Метод, который получает минимальное число массива. Создаём переменную, в которую кладём результат выполнения метода.
// Аргументы мы записываем без указания типа переменной, а параметры с указанием.
double GetMinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

// Метод, который находит разницу между максимальным и минимальным элементом массива
double GetDifferenceNumbers(double max, double min)
{
    return Math.Round(max - min);
}

// Вызываю методы
double[] arrayNumbers = CreateDoubleArray(15, 0, 20);
double maxNumber = GetMaxNumber(arrayNumbers);
double minNumber = GetMinNumber(arrayNumbers);
double differenceNumbers = GetDifferenceNumbers(maxNumber, minNumber);
Console.WriteLine($"В массиве {PrintArray(arrayNumbers)} разница между максимальным и минимальным элементом массива равна {differenceNumbers}");