﻿//// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
////Напишите программу, которая покажет количество чётных чисел в массиве.

//// Блок 1. Ввод цифры задающей размер массива
//Console.Write("Введите число: ");
//int input = Convert.ToInt32(Console.ReadLine());

//// Блок 2. Создание массива на основании введенного числа
//int [] massive = new int [input];

//// Блок 3. Заполнение массива произвольными трехзначными числами

//for (int l = 0; l < input; l++)
//{
    //massive[l] = new Random().Next(100, 1000);
    //Console.Write(massive[l] + " ");
//}

int [] massive = {10,10,10,10,10};

//// Блок 4. Выполнение условий задачи
/// 1. Проверка на четность и подсчет четных чисел.
int count = 0;
int i = 0;
while (i < 5)
{
    if ( massive[i] % 2 == 0)
    {
        count++;
        i++;
    }
    else 
    {
        i++;
    }
    
}
/// 2. Вывод результата
Console.WriteLine();
Console.Write($"Количество четных чисел в данном массиве - {count}.");