//Input
int number = int.Parse(Console.ReadLine());

// Calculating

int evenSum = 0;
int oddSum = 0;

for (int i = 1; i <= number; i++)
{
     int currentNumber = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        evenSum += currentNumber;
    }
    else
    {  
        oddSum += currentNumber; 
    }
}

if (oddSum == evenSum)
{
    Console.WriteLine($"Yes");
    Console.WriteLine($"Sum = {oddSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");

}