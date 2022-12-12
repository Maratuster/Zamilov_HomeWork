/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
// Функция заполнения массива случайными вещественными значениями в пределах заданных
double[] GetArray (int size, int minV, int maxV)
{
    double[] tempArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = new Random().Next(minV, maxV+1);
        //tempArray[i] = Math.Round(tempArray[i], 2);
    }
    Console.Write(string.Join(", ", tempArray));
    return tempArray;
}

// Функция нахождения парных сумм начальных и конечных значений массива
double GetSum (double[] tempArray, int size)
{
    double[] newArray = new double[(size/2)+1];
    for (int i = 0; i < (size/2); i++)
    {
        newArray[i] = tempArray[i] + tempArray[size-1-i];
        Console.Write($"{newArray}, ");
    }
    Console.Write(string.Join(", ", newArray));
    return newArray;
}

Console.Write("Задайте длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте левую границу массива: ");
int leftValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте правую границу массива: ");
int rightValue = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(arraySize, leftValue, rightValue);
array = GetSum(array, rightValue);