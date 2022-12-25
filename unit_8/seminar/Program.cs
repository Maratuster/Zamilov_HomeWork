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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] result = GetMatrix(rows, columns, 0, 20);
PrintMatrix(result);
Console.WriteLine();
/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/



// void ReversRows(int[,] array)
// {
//     int lastRowIndex = array.GetLength(0) - 1;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[0,i];
//         array[0, i] = array[lastRowIndex,i];
//         array[lastRowIndex,i] = temp;

//     }

// }
// ReversRows(result);
// PrintMatrix(result);

/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

// int[,] ChangeArray(int[,] array)
// {
//     int[,] change = new int[array.GetLength(1),array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             change[j,i] = array[i,j];
//         }
//     }
//     return change;
// }
// PrintMatrix(ChangeArray(result));

/*
Задача 61. Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/

// int[,] ChangeArray(int[,] array)
// {
//     int max = int.MinValue;
//     int min = int.MaxValue;
//     int minRow = 0;
//     int minColumn = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (min > array[i, j])
//             {
//                 min = array[i, j];
//                 minRow = i;
//                 minColumn = j;
//             }
//         }

//     }

//     }
//     PrintMatrix(ChangeArray(result));