// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] NewArray (int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = NewArray(len);
Console.WriteLine(String.Join(", ", arr));