//Input

int hourExam = int.Parse(Console.ReadLine());
int minuteExam  = int.Parse(Console.ReadLine());
int hourArrival  = int.Parse(Console.ReadLine());
int minuteArrival  = int.Parse(Console.ReadLine());

int examTimeInMinute = hourExam * 60 + minuteExam;
int arrivalTimeInMinute = hourArrival * 60 + minuteArrival;
int differentInMinute = examTimeInMinute - arrivalTimeInMinute;

if (differentInMinute > 30)
{
    Console.WriteLine("Early");
    if (differentInMinute >= 60)
    {
        int houreEarly = differentInMinute / 60;
        int minuteEarly = differentInMinute % 60;

        if (minuteEarly < 10)
        {
            Console.WriteLine($"{houreEarly}:0{minuteEarly} hours before the start");
        }
        else
        {
            Console.WriteLine($"{houreEarly}:{minuteEarly} hours before the start");
        }
    }
    else
    {
        Console.WriteLine($"{differentInMinute} minutes before the start");
    }
}
else if (differentInMinute < 0)
{
    Console.WriteLine("Late");
    differentInMinute *= -1;

    if (differentInMinute >= 60)
    {
        int houreEarly = differentInMinute / 60;
        int minuteEarly = differentInMinute % 60;

        if (minuteEarly < 10)
        {
            Console.WriteLine($"{houreEarly}:0{minuteEarly} hours after the start");
        }
        else
        {
            Console.WriteLine($"{houreEarly}:{minuteEarly} hours after the start");
        }
    }
    else
    {
        Console.WriteLine($"{differentInMinute} minutes after the start");
    }
}
else
{
    Console.WriteLine("On time");
    
    if(differentInMinute <= 30)
    {
        Console.WriteLine($"{differentInMinute} minutes before the start");
    }
}