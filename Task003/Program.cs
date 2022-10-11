// Задача 23. Напишите программу которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{i * i * i} ");