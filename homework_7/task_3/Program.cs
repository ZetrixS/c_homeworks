//// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//// Блок 1. Вводим рамки массива
Console.Write("Введите кол-во строк: ");
int input_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int input_2 = Convert.ToInt32(Console.ReadLine());

//// Блок 2. Создаем массив на основе введенных данных.
///1. Задаем длину массива, создаем функцию
int [,] massive = new int [input_1, input_2];

void print_massive(int [,] massive)
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
void fill_massive(int [,] massive)
{
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
       massive[i,j] = new Random().Next(1, 10);
    }
    
}
}

//// Блок 3. Выводим результат

print_massive (massive);
Console.WriteLine();
fill_massive(massive);
print_massive(massive);
double count = 0;
double inp_1 = input_1;
//// Блок 4. Выполнение условий задачи
///1. Поиск средне-арифметического в столбце и вывод его
for (int i =0; i < massive.GetLength(1); i++)
{
    for (int l = 0; l < massive.GetLength(0); l++)
    {
        count += massive[l,i]; 
    }
    Console.Write(count / inp_1 + " ");
    count = 0;
}
