/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int [,] GetMatrix(int m, int n, int minV, int maxV)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minV, maxV+1);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        Console.Write(inputArray[i,j] + "\t");
    }
        Console.WriteLine();
    }
}

void GetPosition(int[,] inputArray)
{
    Console.Write("Введите строку нахождения искомого элемента: ");
    int rFind = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите колонку нахождения искомого элемента: ");
    int cFind = Convert.ToInt32(Console.ReadLine());
    
    if (rFind > inputArray.GetLength(0) || cFind > inputArray.GetLength(1)) 
    {
        Console.Write($"[{rFind},{cFind}] - такой строки или колонки не существует.");
    }
    else Console.Write(inputArray[(rFind-1),(cFind-1)]);

}


Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] newArray = GetMatrix(row, column, -99, 99);
PrintArray(newArray);
GetPosition(newArray);