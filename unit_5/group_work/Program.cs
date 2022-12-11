/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

/*
int[] ArrayGener (int size, int minV, int maxV)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minV, maxV+1);
    }
    Console.WriteLine(String.Join(", ", array));
    return array;
    }

int getMinusSum(int[] array, int size)
{
    int minusSum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i]<0) minusSum = minusSum - array[i];
    }
    return minusSum;
}

int getPlusSum(int[] array, int size)
{
    int plusSum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i]>0) plusSum = plusSum + array[i];
    }
    return plusSum;
}

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int miniV = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxiV = Convert.ToInt32(Console.ReadLine());
int[] newArray = ArrayGener(n, miniV, maxiV);
//Console.WriteLine(String.Join(",", newArray));
int minusRes = getMinusSum(newArray, n);
int plusRes = getPlusSum(newArray, n);
Console.WriteLine($"Сумма отрицательных значений массива равна {minusRes * (-1)}");
Console.WriteLine($"Сумма положительных значений массива равна {plusRes}");
*/


/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
/*
int[] ArrayGener (int size, int minV, int maxV)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minV, maxV+1);
    }
    return array;
}

int[] reverseArray( int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = array[i]*(-1);
    }
    return array;
}

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int miniV = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxiV = Convert.ToInt32(Console.ReadLine());
int[] newArray = ArrayGener(n, miniV, maxiV);
Console.WriteLine(String.Join(",", newArray));
newArray = reverseArray(newArray, n);
Console.WriteLine(String.Join(",", newArray));
*/

/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

/*
int[] array = {6, 7, 19, 345, 3};
int find = 2;
int size = array.Length;
int res = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] == find)
    {
        res = array[i];
        break;
    }
}
if (res == find)
{
    Console.WriteLine("Найдено!");
}
else {
    Console.WriteLine("Не найдено!");
}
*/

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
int[] ArrayGener (int size, int minV, int maxV)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minV, maxV+1);
    }
    return array;
}
int getCount (int[] arr, int minV, int maxV)
{
    int count = 0;
    foreach (var i in arr)
    {
        if (i >= minV && i <= maxV)
        {
            count++;
        }
    }
    return count;
}

int[] array = ArrayGener(7, 0, 999);
int minValue = 10;
int maxValue = 99;
int res = getCount(array, minValue, maxValue);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(res);
*/