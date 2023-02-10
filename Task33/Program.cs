// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
// Поиск числа в массиве.
bool FindNumber(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            return true;
        }
    }
    return false;
}

// Создание массива, ввод числа пользователем, вызов функции.
Console.WriteLine("Укажите длину массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] arrayNumb = CreateArrayRNDInt(sizeArray, -9, 9);
PrintArray(arrayNumb);

Console.WriteLine("Укажите число для поиска: ");
int numberToFind = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNumber(arrayNumb, numberToFind) ? "да" : "нет");