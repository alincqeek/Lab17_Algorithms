// See https://aka.ms/new-console-template for more information
static bool IsPrime(int n)
{
    if (n <= 1)
    {
        return false;
    }

    int i = 2;
    while (i * i <= n)
    {
        if (n % i == 0)
        {
            return false;
        }
        i++;
    }

    return true;
}

Console.WriteLine(IsPrime(6));