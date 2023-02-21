// Задача 58:
//  1. Задайте две матрицы. Напишите программу,
//  2. которая будет находить произведение двух матриц.

//  Пример:
//  2 4 | 3 4
//  3 2 | 3 3

//  Результирующая матрица будет:
//  18 20
// 15 18

// GenerateMatrix to generate matrix with random numbers 
int[,] GenerateMatrix(int rows, int columns, int min, int max)
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

//PrintMatrix to print the matrix 
string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLongLength(0); i++)
    {
        str += "["; for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $"{matrix[i, j],3}";
            else str += $"{matrix[i, j],3}, ";
        }
        str += "]\n";
    }
    return str;
}

//MultiplyMatrices to get the product of two matrices 
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMulti = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixMulti.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMulti.GetLength(1); j++)
        {
            matrixMulti[i, j] = 0;
            for (int k = 0; k < matrixMulti.GetLength(1); k++)
            {
                matrixMulti[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixMulti;
}

//Main method to generate two matrices and calculate the product 
int[,] matrixNumberOne = GenerateMatrix(4, 4, 0, 10);
Console.WriteLine($"Matrix 1 - \n{PrintMatrix(matrixNumberOne)}");

int[,] matrixNumberTwo = GenerateMatrix(4, 4, 0, 10);
Console.WriteLine($"Matrix 2 - \n{PrintMatrix(matrixNumberTwo)}");

if (matrixNumberOne.GetLength(1) == matrixNumberTwo.GetLength(0))
{
    int[,] multiMatrix = MultiplyMatrices(matrixNumberOne, matrixNumberTwo);
    Console.WriteLine($"Результирующая матрица - \n{PrintMatrix(multiMatrix)}");
}
else
{
    Console.WriteLine("Нельзя найти произведение матриц");
}