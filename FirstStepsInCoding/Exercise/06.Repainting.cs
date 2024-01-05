//Input

int nylon = int.Parse(Console.ReadLine());
int literPaint = int.Parse(Console.ReadLine());
int thiner = int.Parse(Console.ReadLine());
int hoursForWorking = int.Parse(Console.ReadLine());

//Calkilating

double priceForNylon = (nylon + 2) * 1.50;
double priceForLiter = (literPaint * 1.1) * 14.50;
double priceForThiner = thiner * 5.00;
double matsSum = priceForNylon + priceForLiter + priceForThiner + 0.40;
double workersSum = (matsSum * 0.3) * hoursForWorking;
double finalPrice = matsSum + workersSum;
//Result

Console.WriteLine(finalPrice);