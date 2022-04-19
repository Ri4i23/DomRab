// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
int a = stringNumber[0];
int b = stringNumber[1];
int c = stringNumber[2];
int d = stringNumber[3];
int e = stringNumber[4];

if (a == e && b == d)
{
     Console.WriteLine("Является палиндромом ");
}
else
{
    Console.WriteLine("Не является ");
}