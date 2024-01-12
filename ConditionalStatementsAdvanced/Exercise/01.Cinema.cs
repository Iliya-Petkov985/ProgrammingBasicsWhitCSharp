//Input

string typeProjection = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

double moneyFromTickets = 0;
switch(typeProjection)
{
    case "Premiere": moneyFromTickets = 12; break;
    case "Normal": moneyFromTickets = 7.50; break;
    case "Discount": moneyFromTickets = 5.00; break;

}
double totalMoney = rows * cols * moneyFromTickets;
Console.WriteLine($"{totalMoney:F2} leva");