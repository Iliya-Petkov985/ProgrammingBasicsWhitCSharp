//Input

int nember = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 0; i < nember; i++)
{
    int currenNumber = int.Parse(Console.ReadLine());
    
    sum += currenNumber; 
}
Console.WriteLine(sum);