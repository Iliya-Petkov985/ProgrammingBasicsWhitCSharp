//Input

string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double fruitPrice = 0;
if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
{

    switch (fruit)
    {
        case "banana": fruitPrice = 2.50; break;
        case "apple": fruitPrice = 1.20; break;
        case "orange": fruitPrice = 0.85; break;
        case "grapefruit": fruitPrice = 1.45; break;
        case "kiwi": fruitPrice = 2.70; break;
        case "pineapple": fruitPrice = 5.50; break;
        case "grapes": fruitPrice = 3.85; break;
        default: Console.WriteLine("error"); return; 
    }

  
}
else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
{

    switch (fruit)
    {
        case "banana": fruitPrice = 2.70; break;
        case "apple": fruitPrice = 1.25; break;
        case "orange": fruitPrice = 0.90; break;
        case "grapefruit": fruitPrice = 1.60; break;
        case "kiwi": fruitPrice = 3.00; break;
        case "pineapple": fruitPrice = 5.60; break;
        case "grapes": fruitPrice = 4.20; break;
        default: Console.WriteLine("error");return; 
    } 
    
}
else
{    
    Console.WriteLine("error");return;
}
double finalPrice = quantity * fruitPrice;
Console.WriteLine($"{finalPrice:F2}");