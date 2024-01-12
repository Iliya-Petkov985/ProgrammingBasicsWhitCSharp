//Input

using System.ComponentModel.Design;

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
char operatorOfCalculation = char.Parse(Console.ReadLine());

double result = 0;
string resultType = "";

switch (operatorOfCalculation)
{
    case '+': result = number1 + number2; break;
    case '-': result = number1 - number2; break;
    case '*': result = number1 * number2; break;
    case '/': result = (double)number1 / number2; break;
    case '%': result = (double)number1 % number2; break;
}if (operatorOfCalculation == '+' || operatorOfCalculation == '-' || operatorOfCalculation == '*')
{
    if (result % 2 == 0)
    {
        resultType = "even";
    }
    else
    {   resultType = "odd"; }
    Console.WriteLine($"{number1} {operatorOfCalculation} {number2} = {result} - {resultType}");
        
}
else if (operatorOfCalculation == '/')
{
    if (number1 == 0 || number2 == 0)
    {
        Console.WriteLine($"Cannot divide {number1} by zero");
    }      
    
    
        Console.WriteLine($"{number1} {operatorOfCalculation} {number2} = {result:F2}");
               
}
else if (operatorOfCalculation == '%')
{

    if (number1 == 0 || number2 == 0)
    {
       
        
        Console.WriteLine($"Cannot divide {number1} by zero");//return ;
        
    }
    else
    {
        Console.WriteLine($"{number1} {operatorOfCalculation} {number2} = {result}");
    }
}
