// Задача 50. Напишите программу, 
// которая на вход принимает позиции 
// элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// Далее создаём метод для вывода матрицы
string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "[";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
            else str += $" {matrix[i, j],3} ";
        }
        str += "j\n";
    }
    return str;
}

bool ShowPresenceOfElement(int[,] matrixNumbers, int userRow, int userColumn)
{
    return userRow < matrixNumbers.GetLength(0) && userColumn < matrixNumbers.GetLength(1);
}

// Вызов метода
int[,] matrixNumbers = GetMatrix(3, 4, -10, 10);
Console.WriteLine(PrintMatrix(matrixNumbers));

Console.WriteLine("Введите позицию элемента, начиная с 0. ");
Console.Write("Строка элемента: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец элемента: ");
int userColumn = Convert.ToInt32(Console.ReadLine());

bool presenceNumber = ShowPresenceOfElement(matrixNumbers, userRow, userColumn);
Console.WriteLine(presenceNumber ? $"Элемент массива - {matrixNumbers[userRow, userColumn]}" : "Такого элемента нет");