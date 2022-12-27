/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
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

int GetSum (int M, int N)
{
    if (M > N)
    {
        return (M+GetSum(M-1, N));
    }
    else if (N > M)
    {
        return (N+GetSum(N-1, M));
    }
    else return(M);
    
}

int numberA = GetNumber();
int numberB = GetNumber();
Console.Write(GetSum(numberA, numberB));