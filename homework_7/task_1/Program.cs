//// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.

//// Блок 1. Вводим рамки массива
Console.Write("Введите кол-во строк: ");
int input_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int input_2 = Convert.ToInt32(Console.ReadLine());

//// Блок 2. Создаем массив на основе введенных данных.
///1. Задаем длину массива, создаем функцию
double [,] massive = new double [input_1, input_2];
Random rnd = new Random();

void print_massive(double [,] massive)
{
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        Console.Write($"{massive[i,j]} ");
    }
    Console.WriteLine();
}
}

///2. Создаем функцию для заполнения массива
void fill_massive(double [,] massive)
{
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
       massive[i,j] = Convert.ToDouble(rnd.Next(-9, 10)/10.0);
    }
    
}
}

//// Блок 3. Выводим результат

print_massive (massive);
Console.WriteLine();
fill_massive(massive);
print_massive(massive);