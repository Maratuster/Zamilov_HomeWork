/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/// получаем число из консоли через функцию. Сразу производим проверку на ввод знаков, отличных от чисел.
int GetNumber()
{
    int number = 0;
    Console.Write("Введите число: ");
    try
    {
        number = Convert.ToInt32(Console.ReadLine());
        // return number;
    }
    catch (System.Exception)
    {
        Console.WriteLine("Вы ввели не число. Попробуйте ещё раз.");
        number = GetNumber();
        
    }
    return number;
}

string PrintNumbers (int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start-1,end));

}

int num = GetNumber();
Console.Write(PrintNumbers(num, 1));