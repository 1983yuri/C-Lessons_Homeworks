// Домашняя работа 4 
// Задача 1(Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B)
/*
double CustomMathPow(double num, int exp)
{
    
    double result = num;
    int tempexp = exp; // заводим временную переменную, для отрицательных степеней
    if(exp < 1)
    {
        tempexp = (exp) * -1;
    } 
    for(int count = 1; count < tempexp; count++)
    {
         result *= num;  // result = result * num        
    }

     if(exp == 0)
          {
            result = 1; 
          }
     if(exp < 0)
    {
           result = 1 / result;      
    }                 
    return result;
}

Console.WriteLine("Input the number to be raised to the power: ");
double power = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input a natural number, degree: ");
int degree = Convert.ToInt32(Console.ReadLine());

double mathpow = CustomMathPow(power, degree);

Console.WriteLine($"The number {power} to the power {degree} is {mathpow}");

/*
Задача 2 (Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе)

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

Задача 3 (Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран)

*/
