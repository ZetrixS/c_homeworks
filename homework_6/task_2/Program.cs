//// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//// Блок 1. Ввод чисел

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

//// Блок 2. Определение условий задачи через функции
double y1 (double b1, double k1, double b2, double k2)
{
    double result = 0;
    double x = (b2 - b1) / (k1 - k2);
    result = k1 * x + b1;
    return result;
}

double y2 (double b1, double k1, double b2, double k2)
{
    double result = 0;
    double x = (b2 - b1) / (k1 - k2);
    result = k1 * x + b1;
    return result;
}

//// Блок 3. Вывод результата
if (k1 != k2)
{
    Console.Write("Координаты ваших прямых: " + "(" + y1(b1,k1,b2,k2) + ";" + " " + y2(b1,k1,b2,k2) + ")");
}
else
{
    Console.Write("Ваши прямые не могут пересекаться, они - паралельны.");
}