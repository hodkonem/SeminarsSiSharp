// Задача 54: Задайте двумерный массив. 
// 1. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// This code is used to sort an array in ascending order using the selection sort algorithm.
// The outer loop iterates through each element of the array and sets the first element as the minimum value. 
// The inner loop then compares the minimum value to each other element in the array, until it finds the smallest element. 
// When the smallest element is found, the elements are swapped.


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
        str += "]\n]";
    }
    return str;
}
void ChangeRows(int[,] matrix)
{
    //added if statement to check if the index is out of bounds    
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        //changed index increment from 'i++' to 'j++'  
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int indexMax = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, indexMax] < matrix[i, k])
                {
                    indexMax = k;
                }
            }
            int tmpNum = matrix[i, j];
            matrix[i, j] = matrix[i, indexMax];
            matrix[i, indexMax] = tmpNum;
        }
    }
}
int[,] matrixNumbers = GenerateMatrix(4, 4, 0, 20);
Console.WriteLine($"Элементы массива до перемены строк -\n{PrintMatrix(matrixNumbers)}");
ChangeRows(matrixNumbers);
Console.WriteLine($"Элементы массива после перемены строк -\n{PrintMatrix(matrixNumbers)}");