// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigits(num / 10);
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);

// This code calculates the sum of all digits in a given number. 
// The function SumDigits() takes an integer parameter and checks if the number is equal to 0, if it is, then it returns 0. 
// If the number is not equal to 0, the result of the function is equal to the remainder of num divided by 10 plus the result of SumDigits(num / 10). 
// The main program reads the user input and converts it into an integer. 
// After that, it calls the SumDigits() function to calculate the sum of digits of the given number and prints the result.