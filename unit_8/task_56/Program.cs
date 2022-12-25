/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MinimalSumRow (int[,] inputMatrix)
{
    int sum = int.MaxValue;
    int minSumRow = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            tempSum += inputMatrix[i, j];
        }
        if (tempSum<sum)
        {
            sum = tempSum;
            minSumRow = i;
        }
    }
    Console.Write($"Строка с наименьшей суммой элементов: {minSumRow+1}. Сумма её элеметов равна {sum}");
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] result = GetMatrix(rows, columns, 0, 10);
PrintMatrix(result);
Console.WriteLine();
MinimalSumRow(result);