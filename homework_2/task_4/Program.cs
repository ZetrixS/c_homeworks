//// Задача 4: Напишите программу, которая принимает на вход случайно сгенерированное число 
//// (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23.

//// Блок отвечающий за генерацию числа
int start = 1;
int stop = 1000001;
int random_value = new Random().Next(start, stop);
//// Блок отвечающий за вывод сообщени об успешной генерации
Console.WriteLine("Случайно сгенерированное число - " + random_value);
Console.WriteLine("Определяю кратно-ли число " + random_value + " числам 7 и 23 "+ "...stand by...");
if (random_value % 7 == 0 && random_value % 23 == 0)
{
    Console.Write("Число " + random_value + " одновременно кратно 7 и 23.");
}
else
{
    Console.Write("Число " + random_value + " одновременно не кратно 7 и 23.");
}