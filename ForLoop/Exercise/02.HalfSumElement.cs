//Input



int numnber = int.Parse(Console.ReadLine());

//Calculating
int max = int.MinValue;
int sum = 0;
for (int i = 0; i < numnber; i++)
{
    int currenNumber = int.Parse(Console.ReadLine());

    sum += currenNumber;

    if (currenNumber > max)
    {
        max = currenNumber;
    }
}
int sumWhitOutMax = sum - max;
if (sumWhitOutMax == max)
{ 
        Console.WriteLine($"Yes");
        Console.WriteLine($"Sum = {max}");
}
else 
{
    int diff = Math.Abs(max - sumWhitOutMax);       
        Console.WriteLine($"No");
        Console.WriteLine($"Diff = {diff}");

}

