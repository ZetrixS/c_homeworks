//// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


//// Блок 1. Создание массива.
string[] massive = new string[7] {"test", "hello", "ok", "test_2", "wooah", "1", "34"};
string[] massive_2 = new string[massive.Length];


//// Блок 2. Создание функций.
void massive_fill(string[] massive_1, string[] massive_2)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
    if(massive[i].Length <= 3)
        {
        massive_2[count] = massive[i];
        count++;
        }
    }
}
void massive_print(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]} ");
    }
    Console.WriteLine();
}

////  Блок 3. Вывод результата
massive_fill(massive, massive_2);
massive_print(massive_2);
