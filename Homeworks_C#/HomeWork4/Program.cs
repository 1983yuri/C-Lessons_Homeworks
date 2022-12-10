// Домашняя работа 4 
// Задача 1(Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B)

double CustomMathPow(double num, int exp)
{
    double result = num;
    for(int count = 1; count < exp; count++)
    {
         result *= num; 
    }
    return result;
}

Console.WriteLine("Input the number to be raised to the power: ");
double power = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input a natural number, degree: ");
int degree = Convert.ToInt32(Console.ReadLine());

double mathpow = CustomMathPow(power, degree);

Console.WriteLine($"The number {power} to the power {degree} is {mathpow}");

