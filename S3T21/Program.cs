/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
*/

Console.Write("Введите координату Ax= "); int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Ay= "); int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Az= "); int Az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Bx= "); int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату By= "); int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Bz= "); int Bz = Convert.ToInt32(Console.ReadLine());

int X = Ax - Bx;
int Y = Ay - By;
int Z = Az - Bz;

double Segment = Math.Sqrt((X * X) + (Y * Y) + (Z * Z));

Console.WriteLine("Длина отрезка = " + Segment);

