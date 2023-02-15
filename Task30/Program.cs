// 1. ввод или генерирование
// 2. проверка по условию
// 3. выполнение задачи по условию
// 4. вывод
// Задача 30: 
// Напишите программу, 
// которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// Пример:
// [1,0,1,1,0,1,0,0]

// Нужно создать два отдельных метода: Один заполняет массив элементами (значениями),
// а второй отдельный метод выводит результат массива в консоль. Печатает.

void GetArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] arrayOfZerosOnes = new int[8];
GetArray(arrayOfZerosOnes, 0, 1);
PrintArray(arrayOfZerosOnes);