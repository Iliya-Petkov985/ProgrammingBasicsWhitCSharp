﻿//Input
double number = double.Parse(Console.ReadLine());

int maxN = int.MinValue;
int minN = int.MaxValue;

for (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber < minN)
    {
        minN = currentNumber;       
    }
    if (currentNumber > maxN) 
    {
        maxN = currentNumber;
    }

}
Console.WriteLine($"Max number: {maxN}");
Console.WriteLine($"Min number: {minN}");