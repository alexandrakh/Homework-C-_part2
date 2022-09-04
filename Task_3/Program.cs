//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7:");
int day_week = Convert.ToInt32(Console.ReadLine());
switch(day_week)
{
    case 1:
        Console.WriteLine("Будни");
        break;
    case 2:
        Console.WriteLine("Будни");
        break;
    case 3:
        Console.WriteLine("Будни");
        break;
    case 4:
        Console.WriteLine("Будни");
        break;
    case 5:
        Console.WriteLine("Будни");
        break;
    case 6:
        Console.WriteLine("Выходной");
        break;
    case 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Введено неверное значение");
        break;
}


