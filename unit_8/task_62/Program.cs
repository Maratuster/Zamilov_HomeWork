/*
Задача 62 (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] GetSpiralMatrix(int n)
{
    int[,] matrix = new int[n, n];
    // Ниже спирачено с интернета. Буду разбираться в коде. Пока не понятно ничего
    int pos = 0;
    int count = n;
    int value = -n;
    int sum = -1;
    do {
        value = -1 * value / n;                 //-1*-4/4 =1            -1*4/4=-1
        for (int i = 0; i < count; i++) {
            sum += value;                       // 1) -1+-1 = 0    2) 0+1 = 1    3) 1+1 = 2    4) 2+1 = 3
            matrix[sum / n, sum % n] = pos++;   // 1) matrix[0, 0] = 1    2) matrix[0, 1] = 2    3) matrix[0, 2] = 3    4) matrix[0, 3] = 4
        }
        value *= n;                             // 1*4 = 4
        count--;
        for (int i = 0; i < count; i++) {
            sum += value;                       // 1) 7    2) 11    3) 15    
            matrix[sum / n, sum % n] = pos++;   // 1) matrix[1, 3] = 5    2) matrix[2, 3] = 6    3) matrix[3, 3] = 7
        }
    } while (count > 0);

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
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
int[,] result = GetSpiralMatrix(rows);
PrintMatrix(result);