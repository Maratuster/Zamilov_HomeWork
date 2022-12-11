/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

// Функция нахождения количества чётных значений среди элементов массива
int EvenCount (int[] collection)
{
    int count = 0;
    foreach (var i in collection)
    {
        if (i%2 == 0) count++;
    }
    return count;
}

Console.Write("Задайте длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(arraySize, 100, 999);
Console.WriteLine(String.Join(", ", array));
int evens = EvenCount(array);
Console.WriteLine(evens);