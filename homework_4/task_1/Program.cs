//// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()

//// Блок 1. Ввод чисел
Console.Write("Пожалуйста введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
int grade = number_1;

//// Блок 2. Цикл возведения в степень.
for (int i = 1; i < number_2; i++ )
{
    number_1 = number_1 * grade;
}
Console.Write("Результат возведения первого числа в степень второго: " + number_1);