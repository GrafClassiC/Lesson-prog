// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/* Задача 1
Напишие программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23 */

//Console.WriteLine("Введите число");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a % 7 == 0 && a % 23 == 0) Console.WriteLine("yes");
//else Console.WriteLine("no");

/* Задача 2 
Напишите программу, которая принимает на вход координаты точки (Х и У), причем Х не= 0 и У не= 0 
выдает номер координтной четверти плоскости, в которой находится эта точка. */

//Задача 2
// Console.WriteLine("Введите координату Х");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int Y = Convert.ToInt32(Console.ReadLine());
// if (X>0)
// {
//     if (Y>0) Console.WriteLine("1 четверть");
//     else Console.WriteLine("4 четверть");
// }
// else
// {
//     if (Y>0) Console.WriteLine("2 четверть");
//     else Console.WriteLine("3 четверть");
// }

/* Задача 3
Напишите программу, которая принимает на вход целое число из 
отрезка [10, 99] и показывает наибольшую цифру числа. */

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// while (a<10||a>99) 
// {
//  Console.WriteLine("Введите другое число");  
//  a = Convert.ToInt32(Console.ReadLine()); 
// }
// if (a/10>a%10) Console.WriteLine(a/10); 
// else Console.WriteLine(a%10); 

/* Задача 4
 Напишите программу, которая на вход принимает натуральное число N, 
 а на выходе показывает его цифры через запятую. */

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a;
int n = 1;
while (a1 >= 10)
{
    a1 /= 10;
    n *= 10;
}
while (n >= 10)
{
    Console.Write(a / n % 10 + ", ");
    n /= 10;
}
Console.WriteLine(a % 10);