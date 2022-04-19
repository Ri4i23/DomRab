// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату x первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());
double a = (x2 - x1)*(x2 - x1);
double b = (y2 - y1)*(y2 - y1);
double d = (z2 - z1)*(z2 - z1);
double c = a + b + d;
double distance = Gipotenusa(c);

double Gipotenusa(double sum)
{
   Math.Sqrt(sum);
   return Math.Sqrt(sum);
}
Console.WriteLine($"Расстояние между точками равно {distance} ");
