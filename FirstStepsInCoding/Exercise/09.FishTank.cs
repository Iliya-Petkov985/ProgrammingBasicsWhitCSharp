//Input

int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int heigth = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());


//Calcukating

double volume = length * width * heigth;
double volumeLiter = volume * 0.001;
double accessories = percent / 100;
double neededLiter = volumeLiter * (1 - accessories);


//Resul

Console.WriteLine(neededLiter);


