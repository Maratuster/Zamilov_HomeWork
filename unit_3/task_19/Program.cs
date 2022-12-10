// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); //456
Console.WriteLine("первое число: " + num /10000);
Console.WriteLine("второе число: " + (num /1000)%10);
Console.WriteLine("пятое число: " + num%10);
Console.WriteLine("четвёртое число: " + (num%100)/10);
if (num <10000 || num >=100000) {
        Console.WriteLine("Error. Число не пятизначное");
}
else if (num/10000 == num%10 && (num/1000)%10 == (num%100)/10) {
    Console.WriteLine("Число - палиндром");
}
else Console.WriteLine("Число - не палиндром");