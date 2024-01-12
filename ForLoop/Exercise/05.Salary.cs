//Input

int nemberOpenTab  = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//Calculations



for (int i = 0; i < nemberOpenTab; i++)
{

    string openApp = Console.ReadLine();

    switch(openApp)
    {
        case "Facebook": salary -= 150; break;
        case "Instagram": salary -= 100; break;
        case "Reddit": salary -= 50; break; 
    }
    if (salary <= 0)
    {
        break;
    }   
}
if (salary > 0)
{
    Console.WriteLine(salary);
}
else 
{
    Console.WriteLine($"You have lost your salary.");
}