// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while(index <= N)
{
    Console.Write($"{Cube(index)} " );
    index++;
}
int Cube(int x)
{
    return x*x*x;
}

int a = Cube(index);