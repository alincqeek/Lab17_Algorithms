// See https://aka.ms/new-console-template for more information
static int Sum(int a, int b)
{
    int result = a + b;
    return result;
}
static int Mul(int a, int b)
{
    int result = a * b;
    return result;
}
static int Dele(int a, int b)
{
    int result = a / b;
    return result;
}

int s = 0;
Console.Write("Введите 1 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер операции 1-сумма; 2-умножение; 3-деление: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number3 == 1) 
{ 
    int result = Sum(number1, number2);
    Console.WriteLine($"Результат: {result}");
}
else if (number3 == 2)
{
    int result = Mul(number1, number2);
    Console.WriteLine($"Результат: {result}");
}
else if (number3 == 3)
{
    double  result = Dele(number1, number2);
    Console.WriteLine($"Результат: {result}");
}
else
{
    Console.WriteLine("Неверный номер операции!");
}
