/*
Задача 43 (ДОП, по желанию, на 5 нужно сделать 2 задачки): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
void GetBinariNumber (int num)
{
string twoNum = "";
while (num != 0)
{
    twoNum = twoNum + (char)num%2;
    num/=2;
}
    char[] twoNumA = new char[twoNum.Length];
    for (int i = 0; i < twoNumA.Length; i++)
    {
        twoNumA[i] = twoNum[^(i+1)];
    }
    Console.WriteLine(string.Join("", twoNumA));
}
Console.Write("Введите число любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
GetBinariNumber (number);

