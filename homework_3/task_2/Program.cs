//// Задача 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/// Блок 1. Ввод данных от пользователя.
///.1 Ввод координат первой точки.
Console.Write("Введите значение по оси x для точки А: ");
double A_x_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси y для точки А: ");
double A_y_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси z для точки А: ");
double A_z_1 = Convert.ToInt32(Console.ReadLine());
///.2 Ввод координат второй точки.
Console.Write("Введите значение по оси x для точки B: ");
double B_x_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси y для точки B: ");
double B_y_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение по оси z для точки B: ");
double B_z_2 = Convert.ToInt32(Console.ReadLine());
//// Блок 2. Расчет расстояния между точек
double x = (B_x_2 - A_x_1) * (B_x_2 - A_x_1);
double y = (B_y_2 - A_y_1) * (B_y_2 - A_y_1);
double z = (B_z_2 - A_z_1) * (B_z_2 - A_z_1);
double result =  Math.Sqrt(x + y + z);
Console.Write("Расстояние между вашими точками в 3D: " + result); 
//// Блок 3. Отладка. Проверка правильности расчета самих координат.
// Console.WriteLine("Значение х: " + x);
// Console.WriteLine("Значение y: " + y);
// Console.Write("Значение z: " + z);