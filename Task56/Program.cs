// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GenerateMatrix(int numOfRows, int numOfColumns, int minValue, int maxValue)
{
    int[,] matrix = new int[numOfRows, numOfColumns]; Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "[";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
            else str += $" {matrix[i, j],3}, ";
        }
        str += "]\n";
    }
    return str;
}

int GetMinSumInRows(int[,] matrix)
{
    int indexOfRowWithMinSum = 0;
    int sumOfRows = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int tmpSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tmpSum += matrix[i, j];
        }
        if (i == 0) sumOfRows = tmpSum;
        else
        {
            if (tmpSum < sumOfRows)
            {
                sumOfRows = tmpSum; indexOfRowWithMinSum = i;
            }
        }

    }
    return indexOfRowWithMinSum;
}

int[,] matrixNumbers = GenerateMatrix(4, 4, 0, 20);
Console.WriteLine($"Начальная матрица - \n{PrintMatrix(matrixNumbers)}");

int minSumInRows = GetMinSumInRows(matrixNumbers);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumInRows + 1} строка.");