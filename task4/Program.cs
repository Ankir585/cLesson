// Задача 4: напишите программу, которая принимает на вход три числа и выдает максимальное из чисел.
// Попробую решить ее через массив:
// Введем массив из трех чисел;
// Заполним его случайными числами от 1 до 10;
// сравним первое и второе число массива запишем максимальное число в созданную переменную;
// сравним переменную с максимальным значением и третье число массива;
// выведем результат.


int[] array = new int [3];
int length = array.Length;
int index = 0;
while (index < length) 
{
    array[index] = new Random().Next(1, 10);
    Console.Write(array[index] + " ");
    index++;
}

Console.WriteLine();

int max = array[0];
if (array[0] < array[1]) max = array[1];
if (max < array[2]) max = array[2];

Console.WriteLine(max);