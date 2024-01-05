//Input

int chikenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetableMenu = int.Parse(Console.ReadLine());


//Calkilating

double priceChikenMenu = chikenMenu * 10.35;
double priceFishMenu = fishMenu * 12.40;
double priceVegetableMenu = vegetableMenu * 8.15;

double menuCost = priceChikenMenu + priceFishMenu + priceVegetableMenu;
double priceDessert = menuCost * 0.2;
double finalPrice = menuCost + priceDessert + 2.50;

//Result

Console.WriteLine(finalPrice);
