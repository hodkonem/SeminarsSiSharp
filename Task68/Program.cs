// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// This function calculates the Ackermann function for given m and n values
int CalculateAckermann(int firstParameter, int secondParameter)
{
    if (firstParameter == 0)
    {
        return secondParameter + 1;
    }
    else if (secondParameter == 0)
    {
        return CalculateAckermann(firstParameter - 1, 1);
    }
    else
    {
        return CalculateAckermann(firstParameter - 1, CalculateAckermann(firstParameter, secondParameter - 1));
    }
}

// Test the function with m=2 and n=3
int m = 2;
int n = 3;
int result = CalculateAckermann(m, n);
Console.WriteLine("A({0},{1}) = {2}", m, n, result);