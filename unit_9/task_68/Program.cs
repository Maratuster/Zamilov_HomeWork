/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int Akkerman (int N, int M)
{
    if (N == 0) return (M + 1);
    else if (M == 0) return (Akkerman(N-1, 1));
    else return (Akkerman(N-1, Akkerman(N,M - 1)));
}

int numberA = GetNumber(); // Число N
int numberB = GetNumber(); // Число M
Console.Write(Akkerman(numberA, numberB));