//// Задача 2**. Напишите программу, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4.

////Блок 1. Ввод данных и вывод полученного резултата
int len = 4;
int[,] massive = new int[len, len];
fill_massive_spiral(massive, len);
print_massive(massive);

//// Блок 2. Функции
///1. Функция заполнения массива по спирали начиная с 1
void fill_massive_spiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

///2.  Функция вывода двумерного массива в терминал
void print_massive(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}