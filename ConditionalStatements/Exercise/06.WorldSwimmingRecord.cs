//Input 
double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecForSwimingForOneMeter  = double.Parse(Console.ReadLine());

double needSwimingTime = distanceInMeters * timeInSecForSwimingForOneMeter;
double slowTime = Math.Floor(distanceInMeters / 15) * 12.5;
double totalTime = needSwimingTime + slowTime;

//needSwimingTime += slowTime * 12.5;


if (totalTime < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:F2} seconds slower.");
}
