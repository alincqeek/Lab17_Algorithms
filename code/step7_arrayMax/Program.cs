// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

int[] grade = { 5, 4, 5, 3, 4 };
int s = 0;
for (int i = 0; i <grade.Length ; i++)
{
    if (s<grade[i]) { s = grade[i]; }
};
Console.WriteLine(s);
