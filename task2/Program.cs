// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше а какое меньше.
// Я понял задачу так:
// Для вычисления берем простые случайные числа, которые не равны.

int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);

Console.WriteLine(a);
Console.WriteLine(b);

if (a>b) 
{
    Console.Write("Max = " + a);
}
else 
{
    Console.Write("Max = " + b);
}