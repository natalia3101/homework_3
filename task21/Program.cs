/*
адача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
*/

Console.WriteLine("enter X for point 1");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter Y for point 1");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter Z for point 1");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter X for point 2");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter Y for point 2");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter Z for point 2");
int Z2 = Convert.ToInt32(Console.ReadLine());

double DistanceXY(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
    return result;
}
Console.WriteLine($"distance between ({X1}, {Y1}, {Z1}) and ({X2}, {Y2}, {Z2}) is {DistanceXY(X1, Y1, Z1, X2, Y2, Z2)}");