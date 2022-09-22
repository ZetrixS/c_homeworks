//// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
//// Блок 1. Ввод данных, вывод результата.
int[,] table = new int[4, 4];
fill_massive(table);
print_massive(table);
Console.WriteLine();
print_massive_min(table);

//// Блок 2. Функции
///.1 Функция вывода номера строки с наименьшей суммой элементов 
void print_massive_min(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

///.2 Функция вывода двумерного массива
void print_massive(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

///.3 Функция заполнения массива рандомно числами от 1 до 9
void fill_massive(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
