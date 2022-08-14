﻿/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/


Console.Write("Введите координаты b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите координаты k2: ");
double k2 = double.Parse(Console.ReadLine());

double x = -(b2 - b1)/(k2-k1);
double y = k1 * x + b1;

x = Math.Round(x,3);
y = Math.Round(y,3);

Console.Write("Точка пересечения: " + (x , y));