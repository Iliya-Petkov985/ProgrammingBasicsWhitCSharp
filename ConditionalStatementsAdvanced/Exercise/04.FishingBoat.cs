//Input

int budget = int.Parse(Console.ReadLine());
string seasson = Console.ReadLine();
int numerFishers  = int.Parse(Console.ReadLine());

double rentPrice = 0;

switch (seasson)
{
    case "Spring": rentPrice = 3000; break;
    case "Summer":
    case "Autumn": rentPrice = 4200; break;
    case "Winter": rentPrice = 2600; break;
}
if (numerFishers <= 6)
{
    rentPrice *= 0.90;
}
else if (numerFishers > 6 && numerFishers <= 11)
{
    rentPrice *= 0.85;
}
else if (numerFishers > 11)
{
    rentPrice *= 0.75;
}
double totalPrice = rentPrice;
if (numerFishers % 2 == 0 && seasson != "Autumn")
{
    totalPrice *= 0.95;
}
if (budget >= totalPrice)
{
    Console.WriteLine($"Yes! You have {budget - totalPrice:F2} leva left.");
}
else if(budget < totalPrice)
{
    Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva.");
}