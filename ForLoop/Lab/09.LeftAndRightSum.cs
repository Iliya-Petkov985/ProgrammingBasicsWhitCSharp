//Input

using System.Diagnostics.CodeAnalysis;

int number1 = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < number1; i++)
{
    int currenNumber = int.Parse(Console.ReadLine());

    leftSum += currenNumber;
}
for (int i = 0; i < number1; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    rightSum += currentNumber;
}
if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    int different = Math.Abs(leftSum - rightSum);

    Console.WriteLine($"No, diff = {different}");
}