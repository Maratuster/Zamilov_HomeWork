/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void ColumnsMidSum (int[,] inputArray)
{   
    double midSum = 0;
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            midSum += (double)inputArray[j,i];
        }
        Console.WriteLine($"Среднееарифметическое столбца {i+1} равна {midSum/inputArray.GetLength(1)}");
        midSum = 0;
    }

}

Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] newArray = GetMatrix(row, column, 1, 9);
PrintArray(newArray);
ColumnsMidSum(newArray);