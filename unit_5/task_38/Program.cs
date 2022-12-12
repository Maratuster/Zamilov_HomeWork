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
        tempArray[i] = new Random().NextDouble()*maxV;
        tempArray[i] = Math.Round(tempArray[i], 2);
    }
    Console.WriteLine(string.Join("; ", tempArray));
    return tempArray;
}

// Функция нахождения парных сумм начальных и конечных значений массива
void GetSum (double[] tempArray, int size)
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
        Console.WriteLine($"{min}, {max}");
    }
    double res = max - min;
    Console.WriteLine(res);
}

Console.Write("Задайте длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте левую границу массива: ");
int leftValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте правую границу массива: ");
int rightValue = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(arraySize, leftValue, rightValue);
//array = 
GetSum(array, arraySize);
//Console.Write(string.Join(", ", array));