// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// Пример:
// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

// Функция вывода массива
string PrintArray(int[] arr)
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
// Метод, который будет считать нечётные числа в массиве. Создаём переменную, в которую кладём результат выполнения метода.
// Аргументы мы записываем без указания типа переменной, а параметры с указанием.
int GetSumOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] arrayNumbers = CreateArrayRNDInt(10, -20, 20);
int countOddNumbers = GetSumOddNumbers(arrayNumbers);
Console.WriteLine($"В массиве {PrintArray(arrayNumbers)} сумма чисел, стоящих на нечётных позициях, равна {countOddNumbers}");