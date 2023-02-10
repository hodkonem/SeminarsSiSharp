// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i]; // 1
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}
int[] arr = CreateArrayRNDInt(5, 1, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
// Array.Reverse(arr);
// PrintArray(arr);