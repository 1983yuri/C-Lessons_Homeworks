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


Задача 2 (Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе)

int SumD(int num)
{
    int result = 0;
    int temp = Math.Abs(num); // Берем модуль введенного числа, потому что нас интересует только сумма цифр
   
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


int[] CreateCustomArray(int size)
{
    int[] array = new int[size]; // Инициализации массива, выделение памяти

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} number of elements: ");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return array; // Возвращаем просто имя массива!!!
}

// Метод для вывода массива 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) // Идем по всему массиву
    {    
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); 
    }
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateCustomArray(size);
Console.WriteLine("The elements of custom array is:");
ShowArray(myArray);
*/