//Input
string serialName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int lunchDiration  = int.Parse(Console.ReadLine());

//Calculating

double freeTime = lunchDiration;
freeTime -= lunchDiration / 8.0;
freeTime -= lunchDiration / 4.0;


if(freeTime >= episodeDuration)
{
    double leftTime = Math.Ceiling(freeTime - episodeDuration);
    Console.WriteLine($"You have enough time to watch {serialName} and left with {leftTime} minutes free time.");
}
else
{
    double needTime = Math.Ceiling(episodeDuration - freeTime);
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {needTime} more minutes.");
}