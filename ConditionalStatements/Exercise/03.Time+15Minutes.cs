//Input

int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());

int minuteSum = minute + 15;
//int minuteSum = (minute % 60) + 15;

if(minuteSum > 59)
{
    hour += 1;
    minuteSum %= 60;
    //minuteSum -= 60;  
}
if(hour > 23)
{
    hour = 0;
}
if(minuteSum < 10)
{
    Console.WriteLine($"{hour}:0{minuteSum}");
}
else
{
    Console.WriteLine($"{hour}:{minuteSum}");
}