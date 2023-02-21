// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива. 

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void Replace(int[,] matrix)
{
    int tmp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        tmp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = tmp;
    }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}   |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   |");
    }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
Replace(matrix);
PrintMatrix(matrix);