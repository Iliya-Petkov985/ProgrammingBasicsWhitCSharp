//Input

double budget = double.Parse(Console.ReadLine());
string seassons = Console.ReadLine();


string destination = "";
if (budget <= 100)
{
    destination = "Bulgaria";

}
else if (budget <= 1000)
{
    destination = "Balkans";

}
else
{
    destination = "Europe";

}
double percentOfBudget = 0;
string placeToStay = "";
switch(destination)
{
    case "Bulgaria":
        
       switch(seassons)
        {
            case "summer": percentOfBudget = 0.3;placeToStay = "Camp"; break;
            case "winter": percentOfBudget = 0.7;placeToStay = "Hotel"; break;
        }
        break;
    case "Balkans":

        switch (seassons)
        {
            case "summer": percentOfBudget = 0.4;placeToStay = "Camp"; break;
            case "winter": percentOfBudget = 0.8;placeToStay = "Hotel"; break;
        }
        break;
    case "Europe":

        switch (seassons)
        {
            case "summer": 
            case "winter": percentOfBudget = 0.9;placeToStay = "Hotel"; break;
        }
        break;
}
double moneySpent = budget * percentOfBudget;
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{placeToStay} - {moneySpent:F2}");