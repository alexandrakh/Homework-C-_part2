﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int countdigits = number.ToString().Length;

if(countdigits == 3)
    Console.WriteLine(number / 10 % 10);
else
    Console.WriteLine("Вы ввели неверное число. Введите трехзначное число");