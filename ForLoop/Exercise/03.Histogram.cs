//Input

int number = int.Parse(Console.ReadLine());

//Calculating
double p1 = 0 , p2 = 0 , p3 = 0 , p4 = 0 ,p5 = 0 ;

for (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber < 200)
    {
        p1++;
    }
    else if (currentNumber < 400)
    {
        p2++;
    }
    else if(currentNumber < 600)
    {
        p3++;
    }
    else if (currentNumber < 800)
    {
        p4++;
    }
    else 
    {
        p5++;
    }
}
//Output
Console.WriteLine($"{p1 / number * 100:F2}%");
Console.WriteLine($"{p2 / number * 100:F2}%");
Console.WriteLine($"{p3 / number * 100:F2}%");
Console.WriteLine($"{p4 / number * 100:F2}%");
Console.WriteLine($"{p5 / number * 100:F2}%");