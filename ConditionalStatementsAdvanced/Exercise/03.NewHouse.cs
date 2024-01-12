//Input

string flowers = Console.ReadLine();
int number = int.Parse(Console.ReadLine());
int budget  = int.Parse(Console.ReadLine());


double flowersPrice = 0;

switch(flowers)
{
    case "Roses": flowersPrice = 5; break;
    case "Dahlias": flowersPrice = 3.80; break;
    case "Tulips": flowersPrice = 2.80; break;
    case "Narcissus": flowersPrice = 3; break;
    case "Gladiolus": flowersPrice = 2.50; break;
}
double totalPrice = number * flowersPrice;
if(flowers == "Roses" && number > 80)
{
    totalPrice *= 0.9;
}
else if(flowers == "Dahlias" && number > 90)
{
    totalPrice *= 0.85;
}
else if(flowers == "Tulips" && number > 80)
{
    totalPrice *= 0.85;
}
else if(flowers == "Narcissus" && number < 120)
{
    totalPrice *= 1.15;
}
else if(flowers == "Gladiolus" && number < 80)
{
    totalPrice *= 1.2;
}
if(budget >= totalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {number} {flowers} and {budget - totalPrice:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");
}