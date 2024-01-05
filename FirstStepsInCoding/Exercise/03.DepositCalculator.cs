//Input
double depositSum = double.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());


//Calculating

//double finSumm = depositSum + depositTerm * ((depositSum * annualInterestRate / 100.0) / 12);


double accuredInterest = depositSum * annualInterestRate / 100.0;
double interestForOneMount = accuredInterest / 12;
double finalSum = depositSum + depositTerm * interestForOneMount;

//Result

Console.WriteLine(finalSum);