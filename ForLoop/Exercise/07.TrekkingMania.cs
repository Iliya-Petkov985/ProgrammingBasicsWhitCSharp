//Input

int numberGroup = int.Parse(Console.ReadLine());

//Calculations
double Мусала = 0, Монблан = 0, Килиманджаро = 0, К2 = 0, Еверест = 0;
int allPeople = 0;

for (int i = 0; i < numberGroup; i++)
{
    int numberOfPeopleInGroup = int.Parse(Console.ReadLine());

    allPeople += numberOfPeopleInGroup;

    if (numberOfPeopleInGroup < 6)
    {
        Мусала += numberOfPeopleInGroup;
    }
    else if (numberOfPeopleInGroup < 13)
    {
        Монблан += numberOfPeopleInGroup;
    }
    else if(numberOfPeopleInGroup < 26)
    {
        Килиманджаро += numberOfPeopleInGroup;
    }
    else if (numberOfPeopleInGroup < 41)
    {
        К2 += numberOfPeopleInGroup;
    }
    else
    {
        Еверест += numberOfPeopleInGroup;
    }
}
Console.WriteLine($"{(Мусала / allPeople) * 100:F2}%");
Console.WriteLine($"{(Монблан / allPeople) * 100:F2}%");
Console.WriteLine($"{(Килиманджаро / allPeople) * 100:F2}%");
Console.WriteLine($"{(К2 / allPeople) * 100:F2}%");
Console.WriteLine($"{(Еверест / allPeople) * 100:F2}%");