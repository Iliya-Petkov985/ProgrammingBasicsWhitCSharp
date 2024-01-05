//Input

int numberPackOfPen = int.Parse(Console.ReadLine());
int numberPackOfMarkers = int.Parse(Console.ReadLine());
int literPreparation = int.Parse(Console.ReadLine());
int percentDiscount  = int.Parse(Console.ReadLine()); 


//Calculating

double pricePackOfPen = numberPackOfPen * 5.80;
double pricePackOfMarkers = numberPackOfMarkers * 7.20;
double priceOfPreparation = literPreparation * 1.20;
double priceAllMats = pricePackOfPen + pricePackOfMarkers + priceOfPreparation;
double pricePerDis = percentDiscount / 100.0;
double finalSum = priceAllMats - (priceAllMats * pricePerDis);


//Rresult
Console.WriteLine(finalSum);
