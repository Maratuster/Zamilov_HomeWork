// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++) {
    Console.Write($"{Math.Pow(i, 3)} ");
}