/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
// Функция заполнения массива случайными значениями в пределах заданных
double[] GetArray (int size, int minV, int maxV)
{
    double[] tempArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = Math.Round(new Random().Next(minV, maxV+1), 2);
    }
    Console.Write(string.Join(", ", tempArray));
    return tempArray;
}

Console.Write("Задайте длину массива: ");
int arraySize = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте левую границу массива: ");
int leftValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте правую границу массива: ");
int rightValue = Convert.ToDouble(Console.ReadLine());
double[] array = GetArray(arraySize, leftValue, rightValue);