// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3
int[] GetArray(int count)
{
    int[] newRandom = new int[count];
    for (int i = 0; i < newRandom.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        newRandom[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newRandom;
}

string PrintArray(int[] arr)
{
    string res = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (res == string.Empty) res += arr[i];
        else res += $", {arr[i]}";
    }
    return res;
}

int GetCountPosNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Сколько вы хотите ввести чисел?");
int countNumbers = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = GetArray(countNumbers);

Console.WriteLine(PrintArray(arrayNumbers));
int countPosNumbers = GetCountPosNumbers(arrayNumbers);
Console.Write($"{countPosNumbers} чисел больше нуля");