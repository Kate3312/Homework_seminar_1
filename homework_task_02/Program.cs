﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите 3 числа");
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());

int max = Math.Max (Math.Max(a, b), c);

Console.WriteLine(max);
