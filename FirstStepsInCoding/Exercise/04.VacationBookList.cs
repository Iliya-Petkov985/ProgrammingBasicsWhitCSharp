//Input

int numberOfPagesInBook = int.Parse(Console.ReadLine());
int pagesForOneHourese = int.Parse(Console.ReadLine());
int numberOfDay = int.Parse(Console.ReadLine());

//Calculating

int allForReadBook = numberOfPagesInBook / pagesForOneHourese;
int hourNeedPerDay = allForReadBook / numberOfDay;

//Result

Console.WriteLine(hourNeedPerDay);