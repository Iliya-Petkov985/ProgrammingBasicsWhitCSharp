//Input
int numberOfTournament = int.Parse(Console.ReadLine());
int points = int.Parse(Console.ReadLine());

//Calculating

double pointsFromTornament = 0;
double numberOfWining = 0;
for (int i = 0; i < numberOfTournament; i++)
{
    string roundOfTornament = (Console.ReadLine());
    
    switch(roundOfTornament)
    {
        case "W": points += 2000; pointsFromTornament += 2000; numberOfWining++; break;
        case "F": points += 1200; pointsFromTornament += 1200; break;
        case "SF": points += 720; pointsFromTornament += 720; break;

    }
    
}
double averagePint = Math.Floor(pointsFromTornament / numberOfTournament);
double percentegeWininig = (numberOfWining / numberOfTournament) * 100;

Console.WriteLine($"Final points: {points}");
Console.WriteLine($"Average points: {averagePint}");
Console.WriteLine($"{percentegeWininig:F2}%");