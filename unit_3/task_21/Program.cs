//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите координату первой точки на оси x:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки на оси y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки на оси z:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки на оси x:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки на оси y:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки на оси z:");
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)),2);
Console.Write(d);