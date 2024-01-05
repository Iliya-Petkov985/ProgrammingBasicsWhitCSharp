//Input

double grassing = double.Parse(Console.ReadLine());


//Calculating  

double priceGrassWholeYard = grassing * 7.61;
double discount = priceGrassWholeYard * 0.18;
double finallSum = priceGrassWholeYard - discount;

//Output


Console.WriteLine($"The final price is: {finallSum} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
