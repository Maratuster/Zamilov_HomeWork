// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int NumPower (int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res*a;
    }
    return res;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int power = Convert.ToInt32(Console.ReadLine());
int result = NumPower(num, power);
Console.Write(result);