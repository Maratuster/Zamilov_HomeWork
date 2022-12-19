
//********************************************************************
/*
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/
//********************************************************************
// int [,] GetMatrix(int m, int n, int minV, int maxV)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minV, maxV+1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//     {
//         Console.Write(inputArray[i,j] + "\t");
//     }
//         Console.WriteLine();
//     }
// }

// int[,] newArray = GetMatrix(3, 4, 0, 99);
// PrintArray(newArray);

//********************************************************************

//********************************************************************
/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
//********************************************************************

// int [,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i+j;
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//     {
//         Console.Write(inputArray[i,j] + "\t");
//     }
//         Console.WriteLine();
//     }
// }

// int[,] newArray = GetMatrix(3, 4);
// PrintArray(newArray);
//********************************************************************

//********************************************************************
/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
*/
//********************************************************************
// int [,] GetMatrix(int m, int n, int minV, int maxV)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minV, maxV+1);
//         }
//     }
//     return matrix;
// }

// int [,] GetMatrixQ(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i, j],2));
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//     {
//         Console.Write(inputArray[i,j] + "\t");
//     }
//         Console.WriteLine();
//     }
// }

// int[,] newArray = GetMatrix(3, 4, 1, 5);
// PrintArray(newArray);
// Console.WriteLine();
// newArray = GetMatrixQ(newArray);
// PrintArray(newArray);
//********************************************************************

//********************************************************************
/*
Задача 51. найти сумму элементов главной диагонали
*/
//********************************************************************
// int [,] GetMatrix(int m, int n, int minV, int maxV)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minV, maxV+1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {   
//     int result = 0;
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//     {
//         Console.Write(inputArray[i,j] + "\t");
//         if (i == j) result = result+inputArray[i,j];
//     }
//         Console.WriteLine();
//     }
//     Console.Write($"Сумма элементов главной диагонали: {result}");
// }

// int[,] newArray = GetMatrix(4, 4, 0, 5);
// PrintArray(newArray);
//********************************************************************

//********************************************************************

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

int GetSumOfDiagonal(int[,] inputMatrix)
{
    int sumOfDiagonal = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j+=2)
        {
            if (i == j)
            {
                sumOfDiagonal += inputMatrix[i, j];
            }
        }
    }
    return sumOfDiagonal;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, 0, 10);

PrintMatrix(result);

Console.WriteLine();

int sumGeneralDiagNumber = GetSumOfDiagonal(result);
Console.Write($"Сумма элементов главной диагонали = {sumGeneralDiagNumber}");