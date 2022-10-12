﻿// Задача 19. Напишите программу которая принимает на вход число
// и проверяет является ли оно палиндромом(число которое слева направо читается также как справа налево)
// напр 23432, 12821
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
if (n < 0)
    n = n * (-1);  //это действие проверяет если цифры будут отрицательными
                 //можно писать только n = Math.Abs(n); - это модуль числа тоже проверить на отрицательное число 
while (n < 1000 || n > 99999)
{
    Console.Write("Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
    n = Math.Abs(n);
}
int n1 = n / 10000; // нахождение первой цифры числа
int n2 = (n / 1000) % 10; // нахождение второй цифры числа
int n4 = (n % 100) / 10;
int n5 = n % 10; 
if (n1 == n5 && n2 == n4)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");