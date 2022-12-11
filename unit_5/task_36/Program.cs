/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// Функция заполнения массива случайными значениями в пределах заданных
int[] GetArray (int size, int minV, int maxV)
{
    int[] tempArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = new Random().Next(minV, maxV+1);
    }
    return tempArray;
}

// Функция нахождения суммы нечётных значений среди элементов массива
int UnevenSum (int[] collection)
{
    int sum = 0;
    foreach (var i in collection)
    {
        if (i%2 == 1 || i%2 == -1) sum = sum+(i);
    }
    return sum;
}

Console.Write("Задайте длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте левую границу массива: ");
int leftValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте правую границу массива: ");
int rightValue = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(arraySize, leftValue, rightValue);
Console.WriteLine(String.Join(", ", array));
int evens = UnevenSum(array);
Console.WriteLine(evens);