﻿//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли оно четным (делится на 2 без остатка)
//Сгенерируем случайное число от -10 до 10
//Произведем целочисленное деление числа на 2
//если остаток 0, тогда число четное если нет, то нечетное
//Выведем результат в консоль.


int a = new Random().Next(-10, 10);
Console.WriteLine($"Сгенерировано {a}");
int mod = a % 2;
if (mod == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}