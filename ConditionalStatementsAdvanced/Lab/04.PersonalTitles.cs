﻿//Input

double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (gender == 'f')
{
    if (age >= 16)
    {
        Console.WriteLine("Ms.");
    }
    else if(age < 16)
    {
        Console.WriteLine("Miss");
    }
}
else if (gender == 'm')
{
    if (age >= 16)
    {
        Console.WriteLine("Mr.");
    }
    else if (age < 16)
    {
        Console.WriteLine("Master");
    }
}