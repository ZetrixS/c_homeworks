int number = 0;
Console.Write("Введите число:");
string input = Console.ReadLine();
number = Convert.ToInt32(input);
if (number%2 == 0)
{
    Console.Write("Число " + number + " - четное.");
}
else
{
    Console.Write("Число " + number + " - не четное." );
}