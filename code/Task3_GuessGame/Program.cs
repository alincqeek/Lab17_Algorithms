// See https://aka.ms/new-console-template for more information
Console.Write("Введите число от 1 до 100: ");
int a = Convert.ToInt32(Console.ReadLine());
int s = 0;
Random rand = new Random();
int r = rand.Next(1, 101);
while (s == 0)
{
    if (a < r)
    {
        Console.WriteLine("меньше r");
        Console.Write("Введи еще раз: ");
         a = Convert.ToInt32(Console.ReadLine());
    }
    else if (a > r)
    {
        Console.WriteLine("больше r");
        Console.Write("Введи еще раз: ");
         a = Convert.ToInt32(Console.ReadLine());
    }
    else { Console.WriteLine("Урааа угадал");s = 1; }
}