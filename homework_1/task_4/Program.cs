Console.Write("Введите число:");
string input = Console.ReadLine();
N = Convert.ToInt32(input);
for (int n = 2; n < N + 1; n = n + 2)
{
    Console.Write( n + " ");
}