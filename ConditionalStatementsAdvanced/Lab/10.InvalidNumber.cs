//Input

int number = int.Parse(Console.ReadLine());

//Callculating
bool isValide = number >= 100 && number <= 200 || number == 0;
if (!isValide)
{
    Console.WriteLine("invalid");
}



