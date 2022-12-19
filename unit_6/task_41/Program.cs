/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int[] GetArray (int size)
{
    int[] tempArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число и нажмите интер: ");
        tempArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return tempArray;
}

// Функция нахождения количества чётных значений среди элементов массива
int EvenCount (int[] collection)
{
    int count = 0;
    foreach (var i in collection)
    {
        if (i>0) count++;
    }
    return count;
}

Console.Write("Задайте длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(arraySize);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(EvenCount(array));