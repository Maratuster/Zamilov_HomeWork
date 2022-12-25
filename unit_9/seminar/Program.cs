// Заполнение двумерного массива одним циклом

// int rows = 2;
// int columns = 2;
// int[,] array = new int[2,2]; // 2 строчки, 2 столбца

// for (int i = 0; i < rows * columns; i++)
// {
//     array[i / columns, i % columns] = new Random().Next(11);
// }


/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
// int num = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers (int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start+1,end));

// }
// Console.Write(PrintNumbers(1, num));

/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumbers (int num)
// {
//     if (num == 0) return 0;
//     return (num % 10 + SumNumbers(num/10));
// }
// Console.Write(SumNumbers(number));

/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
// int GetPower (int number, int power)
// {
//     if (power == 0) return 1;
//     if (power == 1) return number;
//     return (number*GetPower(number, power-1));
// }
// int count = 0;
// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// Console.Write(GetPower(numberA, numberB));