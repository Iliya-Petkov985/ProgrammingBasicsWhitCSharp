//Input

int hour = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

//Calculating

if (hour >= 10 && hour <= 18 && dayOfWeek != "Sunday")
{
    switch (dayOfWeek)
    {
        case "Monday": break;
        case "Tuesday": break;
        case "Wednesday": break;
        case "Thursday": break;
        case "Friday": break;
        case "Saturday": break;       
    }
    Console.WriteLine("open");
}
else
{

    Console.WriteLine("closed");
}