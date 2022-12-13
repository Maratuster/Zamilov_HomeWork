/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
// Функция заполнения массива случайными вещественными значениями в пределах заданных
double[] GetArray (int size)
{
    double[] tempArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = new Random().NextDouble()*100;
        tempArray[i] = Math.Round(tempArray[i], 2);
    }
    Console.WriteLine(string.Join("; ", tempArray));
    return tempArray;
}

// Функция нахождения парных сумм начальных и конечных значений массива
double GetSum (double[] tempArray, int size)
{
    double min = tempArray[0];
    double max = tempArray[0];
    foreach (var i in tempArray)
    {
        if (i <= min) 
        {
            min = i;
        }
        else if (i>=max)
        {
            max = i;
        }
    }
    double res = max - min;
    return res;
}

Console.Write("Задайте длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(arraySize);
double result = Math.Round(GetSum(array, arraySize), 2);
Console.Write(result);