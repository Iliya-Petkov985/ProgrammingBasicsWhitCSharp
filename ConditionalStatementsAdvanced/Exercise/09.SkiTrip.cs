//Input

int stayDays = int.Parse(Console.ReadLine());
string typeOfRoom  = Console.ReadLine();
string rating = Console.ReadLine();

//Calculating
double priceForOneNight = 0;
switch(typeOfRoom)
{
    case "room for one person":priceForOneNight = 18.00; break;
    case "apartment":priceForOneNight = 25.00; break;
    case "president apartment":priceForOneNight = 35.00; break;

}
stayDays -= 1;
double totalPrice = priceForOneNight * stayDays;
if(typeOfRoom == "apartment")
{
   if(stayDays < 10)
    { 
        totalPrice *= 0.7; 
    }
   else if(stayDays >= 10 && stayDays <= 15) 
    {
        totalPrice *= 0.65;     
    }
   else
    {
        totalPrice *= 0.5;
    }
}
else if(typeOfRoom == "president apartment")
{
    if(stayDays < 10)
    {
        totalPrice *= 0.9;
    }
   else if (stayDays >= 10 && stayDays <= 15)
    {
        totalPrice *= 0.85;
    }
    else
    {
        totalPrice *= 0.8;
    }

}
else
{
    totalPrice = totalPrice;
}
double finalPrice = 0;
if(rating == "positive")
{
    finalPrice = totalPrice + totalPrice * 0.25;
}
else if(rating == "negative")
{
    finalPrice = totalPrice - totalPrice * 0.1;
}
Console.WriteLine($"{finalPrice:F2}");