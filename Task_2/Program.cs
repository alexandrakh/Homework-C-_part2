﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int countdigits = number.ToString().Length; 

if (countdigits >= 3)
    Console.WriteLine(number.ToString()[2]);
else
     Console.WriteLine("Третьей цифры нет");