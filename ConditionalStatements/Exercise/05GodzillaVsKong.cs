//Input
double moneyForMovie = double.Parse(Console.ReadLine());
int numberStatist = int.Parse(Console.ReadLine());
double priceForGearOneStatist  = double.Parse(Console.ReadLine());

//Calculating

double decor = moneyForMovie * 0.1;
double totalPriceForGear = numberStatist * priceForGearOneStatist;

if (numberStatist > 150)
{
    totalPriceForGear *= 0.9;
}
double totalSum = decor + totalPriceForGear;
if (totalSum > moneyForMovie)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {totalSum - moneyForMovie:F2} leva more.");

}  
else if(totalSum <= moneyForMovie)
 {
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyForMovie - totalSum:F2} leva left.");
 }
