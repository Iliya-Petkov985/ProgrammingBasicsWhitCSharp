//Input

int annualPrice = int.Parse(Console.ReadLine());

//Calculatin

double shoesPrice = annualPrice - (annualPrice * 0.4);
double outfitPrice = shoesPrice - (shoesPrice * 0.2);
double ballPrice = outfitPrice / 4;
double accessories = ballPrice / 5;
double finalPrice = annualPrice + shoesPrice + outfitPrice + ballPrice + accessories;


//Result

Console.WriteLine(finalPrice);