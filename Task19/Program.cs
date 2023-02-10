// Задача 19
// Напишите программу,
// которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
while (userNumber < 0 || userNumber > 99999 || userNumber < 10000)
{
    Console.WriteLine("Вы ввели неправильное число. Введите пятизначное число ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
bool palindromeDetection = PalindromeDetection(userNumber);
bool PalindromeDetection(int number)
{
    return number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10;
}
Console.WriteLine(palindromeDetection ? "Число является палиндромом." : "Число не является палиндромом.");