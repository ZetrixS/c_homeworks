//// Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, 
//// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

//// Блок 4. Выполнение условий задачи
///1. Ввод запроса поиска
Console.WriteLine("Инициализирую код поиска елемента массива.....stand by.....");
Console.Write("Введите № в строке для поиска: ");
int inp_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите № в столбце для поиска: ");
int inp_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число: " + massive[inp_1-1,inp_2-1]);
