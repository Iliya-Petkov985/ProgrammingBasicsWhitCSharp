//Input

double priceExcursion = double.Parse(Console.ReadLine());
int puzzels = int.Parse(Console.ReadLine());
int dools = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions  = int.Parse(Console.ReadLine());
int truck = int.Parse(Console.ReadLine());

double totalSum = puzzels * 2.60 + dools * 3 + bears * 4.10 + minions * 8.20 + truck * 2;
int toys = puzzels + dools + bears + minions + truck;

if(toys >= 50)
{
    totalSum *= 0.75;// totalSum - (totalSum * 0.25);
    
}
totalSum *= 0.9; // totalSum - (totalSum * 0.10;
if (totalSum >= priceExcursion)
{
    Console.WriteLine($"Yes! {totalSum - priceExcursion:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {priceExcursion - totalSum:F2} lv needed.");
}