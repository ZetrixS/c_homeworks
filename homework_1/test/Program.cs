Console.Write("Введите первое число и нажмите клавишу Enter: ");
string input_N = Console.ReadLine();
int N = Convert.ToInt32(input_N);
for (int i = 2; i <= N; i+=2)
{
    Console.WriteLine(i);
}