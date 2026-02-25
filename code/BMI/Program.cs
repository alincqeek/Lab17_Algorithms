// See https://aka.ms/new-console-template for more information
Console.Write("Введите вес числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите рост числа: ");
double number2 = Convert.ToDouble(Console.ReadLine());
double bmi = number1 / (Math.Pow(number2, 2));
Console.WriteLine(bmi);
if (bmi < 18.5)
{
    Console.WriteLine("Недостаточный вес");
}
else if (18.5 < bmi && bmi< 24.9)
{
    Console.WriteLine("Нормальный вес");
}
else if (24.9<bmi && bmi< 29.9)
{
    Console.WriteLine("Избыточный вес");
}
else
{
    Console.WriteLine("Ожирение");
}
