// Домашняя работа 4 
// Задача 1(Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B)
/*

double CustomMathPow(double num, int exp)
{
    double result = num;
    int tempexp = |exp|; // заводим временную переменную, по модулю и смотрим в for count < tempexp 
    for(int count = 1; count < exp; count++)
    {
         result *= num;  // result = result * num        
    }
    if(exp == 0)
         {
           result = 1; 
         }
    else if(exp < 0)
    {
           result = 1 / (result * num);      
    }                 
    return result;
}

Console.WriteLine("Input the number to be raised to the power: ");
double power = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input a natural number, degree: ");
int degree = Convert.ToInt32(Console.ReadLine());

double mathpow = CustomMathPow(power, degree);

Console.WriteLine($"The number {power} to the power {degree} is {mathpow}");

Задача 2 (Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.)
*/
int SumD(int num)
{
    int result = 0;
    int temp = num;
   
    while(temp > 0)
    {
        result = result + temp % 10;
        temp = temp / 10;    
    }
    return result;
}

Console.WriteLine("Input an integer number");
int usernumb = Convert.ToInt32(Console.ReadLine());

int sumD = SumD(usernumb);

Console.WriteLine($"The sum of digits number {usernumb} is {sumD}");

