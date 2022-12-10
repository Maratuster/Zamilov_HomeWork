// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <100) {
    Console.WriteLine("Error");
}
else if (num >=100 && num <1000) {
    num = num / 10;
    Console.WriteLine(num%10);

}
else {
    Console.WriteLine("Error");
}