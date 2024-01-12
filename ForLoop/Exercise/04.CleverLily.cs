//Input
int age = int.Parse(Console.ReadLine());
double washMachinePrice = double.Parse(Console.ReadLine());
int priceForOneToy = int.Parse(Console.ReadLine());

//Calculating

int evenBirthDay = 10;
int sum = 0, sumToys = 0;

for (int cuurentAge = 1; cuurentAge <= age; cuurentAge++)
{
    if (cuurentAge % 2 == 0)
    {
        sum += evenBirthDay - 1;
        evenBirthDay += 10;
    }
    else
    {
        sumToys += priceForOneToy; 
    }

}
double moneySave = sum + sumToys;
if (moneySave >= washMachinePrice)
{
    Console.WriteLine($"Yes! {moneySave - washMachinePrice:F2}");
}
else
{
  Console.WriteLine($"No! {washMachinePrice - moneySave:F2}");
}