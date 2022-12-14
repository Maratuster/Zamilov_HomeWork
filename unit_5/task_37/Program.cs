/*
Задача 37 со звездочкой, дополнительная: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int[] GetArray (int size, int minV, int maxV)
{
    int[] tempArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = new Random().Next(minV, maxV+1);
    }
    return tempArray;
}

int[] productOfNumbers (int[] array, int size)
{
    int[] tempArray = new int[size/2];
    for (int i = 0; i <= size/2; i++)
    {
        if (i == (size-1-i))
        {
            tempArray[i] = array[i];
        }
        else 
        {
            tempArray[i] = array[i]*array[size-1-i];
        }
    }
    return tempArray;
}

Console.Write("Задайте длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(arraySize, 0, 999);
Console.WriteLine(String.Join(", ", array));
int[] newArray = productOfNumbers(array, arraySize);
Console.WriteLine(String.Join(", ", newArray));
