//// Задача 3. Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
//// Напишите программу, которая будет построчно выводить массив.

//// Блок 1. Создание массива, вывод данных
int[,] massive = new int[5, 5];
fill_massive(massive);
print_massive(massive);

//// Блок 2. Функции
///.1 Функция вывода элементов массива
void print_massive(int[,] arr)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j ]} ");
        }
    }
}

///.2 Функция заполнения  массива не повторяющимеся числами
void fill_massive(int[,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[ i, j] += count;
            count += 3;
        }
    }
}

