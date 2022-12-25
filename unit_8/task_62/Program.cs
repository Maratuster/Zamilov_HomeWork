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
    int elementMean = 1;
    int count = n;
    int value = -n;
    int position = -1;
    do {
        value = -1 * value / n;
        for (int i = 0; i < count; i++) {
            position += value;
            matrix[position / n, position % n] = elementMean++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++) {
            position += value;  
            matrix[position / n, position % n] = elementMean++;
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