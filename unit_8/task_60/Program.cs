/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] GetMatrix(int m, int n, int d, int minValue, int maxValue)
{
    int[,,] matrix = new int[m, n, d];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
            
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int k = 0; k < inputMatrix.GetLength(2); k++)
        {
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                Console.Write($"{inputMatrix[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] result = GetMatrix(rows, columns, depth, 0, 20);
PrintMatrix(result);