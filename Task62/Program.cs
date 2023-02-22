// *Задача 62. 
// 1. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// *Задача 62. 

// 1. Напишите программу, которая заполнит спирально массив 4 на 4.
// 2. Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// The following C# code will fill an array with a 4x4 helical array.
// *Задача 62. 
// 1. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillHelicalArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    int i = 0;
    int j = 0;
    matrix[i, j] = count;
    while (count <= matrix.Length)
    {
        while (j + 1 < matrix.GetLength(1) && matrix[i, j + 1] == 0)
        {
            j++;
            matrix[i, j] = ++count;
        }
        while (i + 1 < matrix.GetLength(0) && matrix[i + 1, j] == 0)
        {
            i++;
            matrix[i, j] = ++count;
        }
        while (j - 1 >= 0 && matrix[i, j - 1] == 0)
        {
            j--;
            matrix[i, j] = ++count;
        }
        while (i - 1 >= 0 && matrix[i - 1, j] == 0)
        {
            i--;
            matrix[i, j] = ++count;
        }
        if (count == matrix.Length) count++; //без этой строчки всегда будет выполнятся равенство условия while (count <= matrix.Length) и цикл будет бесконечный
    }
    return matrix;
}

//This code prints out a matrix of numbers.
string PrintMatrix(int[,] matrix)
{
    //Initialize an empty string
    string str = string.Empty;

    //Loop through the rows
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Add an opening bracket to the string
        str += "[";
        //Loop through the columns
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //If this is the last element in the row, add the element to the string with 3 spaces for formatting
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3}";//всесто matrix.GetLength(i) -> matrix.GetLength(1)
            //Otherwise add the element to the string with 3 spaces and a comma for formatting
            else str += $" {matrix[i, j],3}, ";
        }
        //Add a closing bracket and a new line character to the string
        str += "]\n";
    }
    //Return the string
    return str;
}

//Create an array
int[,] matrixNumbers = FillHelicalArray(4, 4);
//Print out the matrix
Console.WriteLine(PrintMatrix(matrixNumbers));