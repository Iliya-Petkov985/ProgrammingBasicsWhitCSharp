//Input

string month = Console.ReadLine();
int numberOfOvernightStay = int.Parse(Console.ReadLine());

double studioPrice = 0;
double apartmentPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = 50;
    apartmentPrice = 65;
    if(numberOfOvernightStay > 7 && numberOfOvernightStay <= 14)
    { studioPrice *= 0.95;
    }
    else if(numberOfOvernightStay > 14)
    { studioPrice *= 0.70;}
}
else if(month == "June" || month == "September")
{
    studioPrice = 75.20;
    apartmentPrice = 68.70;
    if (numberOfOvernightStay > 14)
    { studioPrice *= 0.80; }
}
else if(month == "July" || month == "August")
{
    studioPrice = 76;
    apartmentPrice = 77;
}
if(numberOfOvernightStay > 14)
{
    apartmentPrice *= 0.9;
}
double totalCostForStudio = studioPrice * numberOfOvernightStay;
double totalCostForApartment = apartmentPrice * numberOfOvernightStay;
Console.WriteLine($"Apartment: {totalCostForApartment:F2} lv.");
Console.WriteLine($"Studio: {totalCostForStudio:F2} lv.");