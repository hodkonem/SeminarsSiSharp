// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Функция создания массива
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
// Инверсия массива
void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

//Вызовы методов
int[] arrNumb = CreateArrayRNDInt(10, -10, 10);
PrintArray(arrNumb);
InverseArray(arrNumb);
PrintArray(arrNumb);