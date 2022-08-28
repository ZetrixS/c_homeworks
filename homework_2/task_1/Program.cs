﻿//// Задача 1: Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.

//// Блок отвечающий за генерацию трехзначного числа
int start = 100;
int stop = 1000;
int random_value = new Random().Next(start, stop);
//// Блок отвечающий за вывод сообщени об успешной генерации
Console.WriteLine("Случайно сгенерированное число - " + random_value);
Console.WriteLine("Определяю вторую по счету цифру в числе...stand by....");
//// Блок отвечающий за саму механику выбора второй цифры
///.1 Определяем первые две цифры, посредством деления оператором "/" на 10, в данном случае остаток не учитывается
int number_1 = random_value / 10;
///.2 Так как выше при деление у нас остаток не учитывался, переменная примет вид первых двух цифр без остатка,
///. нам останется применить оператор "%" который и выдаст нам остаток от деления числа, что и будет являться второй
///. по счету цифрой в трехзначном числе.
int number_2 = number_1 % 10;
///.3 Выводим получившейся результат
Console.Write("Вторая по счету цифра в трехзначном числе - " + number_2);