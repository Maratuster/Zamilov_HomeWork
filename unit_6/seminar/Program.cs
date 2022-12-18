/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/
/*
int[] GetArray (int size, int minV, int maxV)
{
    int[] tempArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = new Random().Next(minV, maxV+1);
    }
    return tempArray;
}

int[] ReverseArray (int[] collection)
{
    int size = collection.Length;
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = collection[^(i+1)];
    }
    return newArray;
}

int[] array = GetArray(6, 1, 99);
Console.WriteLine(string.Join("; ", array));
int[] reverseArray = ReverseArray(array);
Console.WriteLine(string.Join("; ", reverseArray));


//void BubbleSort (int[] collection)
//{
    // меняем местами элементы массива с помощью временной переменной
//}
*/

/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
*/

/*
Число Фибоначи
*/
/*
int firstElement = 0;
int secondElement = 1;
int number = 8; // Количество чисел Фибоначчи: 0,1,1,2

Console.WriteLine($"1 элемент. {firstElement}");
Console.WriteLine($"2 элемент. {secondElement}");

for (int i = 3; i <= number; i++)
{
    int nextElement = firstElement + secondElement; //next = 1
    Console.WriteLine($"{i} элемент. {nextElement}");
    firstElement = secondElement;
    secondElement = nextElement;
}
*/