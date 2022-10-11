// Задача 21 Напишите программу которая принимает на вход координаты 
//  
Console.Clear();
Console.Write("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату c1: ");
double c1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату c2: ");
double c2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (c1 - c2) * (c1 - c2)));