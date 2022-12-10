//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); //456
if (num <100) {
    Console.WriteLine("Error. Число меньше, чем трёхзначное");
}
else if (num >=100 && num <=999) { 
    Console.WriteLine(num%10);
}
else {
    while (num>999)
    {
        num = num /10;
    }
    Console.WriteLine(num%10);
}