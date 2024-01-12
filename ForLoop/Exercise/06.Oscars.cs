//Input

string actorName = Console.ReadLine();
double point = double.Parse(Console.ReadLine());
int juges  = int.Parse(Console.ReadLine());

//Calculations

for (int i = 0; i < juges; i++)
{

    string jugesName = Console.ReadLine();
    double pointFromJuges = double.Parse(Console.ReadLine());

    point += (jugesName.Length * pointFromJuges) / 2;

    if (point > 1250.5)
    {
        break;

    }
}
if (point < 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - point:F1} more!");
}
else
{
    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {point:F1}!");
}