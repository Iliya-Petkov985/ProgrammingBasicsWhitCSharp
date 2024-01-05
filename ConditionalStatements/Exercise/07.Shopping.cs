//Input

double moneyPeter = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processores = int.Parse(Console.ReadLine());
int ramMemory = int.Parse(Console.ReadLine());

//Calculating

double priceVideoCard = videoCards * 250;
double priceProcessores = processores * (priceVideoCard * 0.35);
double priceRamMemory = ramMemory * (priceVideoCard * 0.1);
double totalSum = priceVideoCard + priceProcessores + priceRamMemory;

if(videoCards > processores)
{
    totalSum *= 0.85;
}
if(moneyPeter >= totalSum)
{
    Console.WriteLine($"You have {moneyPeter - totalSum:F2} leva left!");
}
else if(moneyPeter < totalSum)
{
    Console.WriteLine($"Not enough money! You need {totalSum - moneyPeter:F2} leva more!");
}