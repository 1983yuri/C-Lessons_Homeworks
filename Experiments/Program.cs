// Задача про двух друзей и собаку
/*
int FriendsVsDog(double distance, int firstFriendSpeed, int secondFriendSpeed, int dogSpeed)
{
    int count = 0;
    int friend = 2;
    double time = 0;

while(distance > 10)
{
  if(friend == 1)
      {
      time = distance / (firstFriendSpeed + dogSpeed);
      friend = 2;
      distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
      count++;
      }
  else
      {
      time = distance / (secondFriendSpeed + dogSpeed);
      friend = 1;
      distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
      count++; 
      }     
}
return count;
}


Console.WriteLine("Enter the distance in meters: ");
double distance = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a first friend speed: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second friend speed: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a dog speed: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int friendvsdog = FriendsVsDog(distance, firstFriendSpeed, secondFriendSpeed, dogSpeed);


Console.Write($"The dog will run from one friend to the second friend: {friendvsdog} times!");



int[] FillArray(int size, int minValue, int maxValue)
{
    int i = 0;
    int[] array = new int[size];
    while(i < size)
   {
    array[i] = new Random().Next(minValue, maxValue -1); 
    i++;
   }
   return array;
}

void ShowArray(int[] array)
{
    int i = 0;
    int j = 0;
    while(i < array.Length)
    {
      Console.WriteLine($" element [{j + 1}] is {array[i]}");
      i++;
      j++;
    }
    
}

Console.WriteLine("Input the array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of the array size: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = FillArray(size, minValue, maxValue);
ShowArray(myArray);


// Объектно - ориентированное
class Person
 {
 public string firstName;
 public string lastName;

 public void ShowFullName()
 {
Console.WriteLine($"Name is “ {firstName} {lastName}");
 }
 }

Petr = new Person();
Petr.firstName = “Petr”;

Petr.ShowFullName();


int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод создания и заполнения массива числами в заданном диапазоне
{
    int[] array = new int[size]; // Инициализации массива, выделение памяти

    for(int i = 0; i < size; i++)
    {          
        array[i] = new Random().Next(minValue, maxValue + 1);  // +1 потому, что [)    
    }
    return array; // Возвращаем просто имя массива!!!
}

 

void ShowArray(int[] array) // Метод вывода массива в консоль
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); 
    }
}

void OrderArray(int[] array)  // Метод сортировки одномерного массива по убыванию
{
    int temp = 0;
    for(int i = 0; i < array.Length -1; i++)
       for(int j = i + 1; j < array.Length; j++)
        {
            if(array[i] < array[j])
            {
               temp = array[i];
               array[i] = array[j];
               array[j] = temp;
            }
        }
}

int[] myArray = CreateRandomArray(10, 0, 9);
ShowArray(myArray);
Console.WriteLine();
OrderArray(myArray);
ShowArray(myArray);


int[] CreateArray(int size) // Метод создания и заполнения массива числами в заданном диапазоне
{
    int[] array = new int[size]; // Инициализации массива, выделение памяти
    
    int nums = 10;

    for(int i = 0; i < size; i++)
    {
      array[i] = nums;
      nums++;   
    }           
           
    return array; // Возвращаем просто имя массива!!!
}

 

void ShowArray(int[] array) // Метод вывода массива в консоль
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); 
    }
}

Console.WriteLine("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
if(size > 90) goto Found;
int[] myArray = CreateArray(size);
ShowArray(myArray);
Found: Console.WriteLine("Array size exceeds possible number of values! Restart the program and input new values!");


// Самостоятельное решение со змейкой

int[,] CreateSnakeArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];

    int nums = 10;
    int startRow = 0;
    int endRow = rows - 1;
    int startColumn = 0;
    int endColumn = columns - 1;

    while(startRow <= endRow  && startColumn <= endColumn)
    {
        for(int j = startColumn; j <= endColumn; j++)
        {
            arr[startRow, j] = nums;
            nums++;
        }
        startRow++;
    
        for(int i = startRow; i <= endRow; i++)
        {
            arr[i, endColumn] = nums;
            nums++;
        }
        endColumn--;

        for(int j = endColumn; j >= startColumn; j--)
        {
            arr[endRow, j] = nums;
            nums++;
        }
        endRow--;

        for(int i = endRow; i >= startRow; i--)
        {
            arr[i, startColumn] = nums;
            nums++;
        }
        startColumn++;     
    }
    return arr;
}

void Show2dArray(int[,] array) // Метод вывода 2х мерного массива
{
    for(int i = 0; i < array.GetLength(0); i++) // Ноль по строкам, 1 по столбцам
    {
        for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] mySnakeArray = CreateSnakeArray(7, 6);
Show2dArray(mySnakeArray);


// Взвешивание гирек в массиве

void MaxWeight()
{
int weight = 0;

Console.WriteLine("How many weights you need weigh?");
int size = Convert.ToInt32(Console.ReadLine());
int[] weightArr = new int[size];
int maxweight = weightArr[0];


do
{
  Console.WriteLine($"Input the numbers of weight: {weight + 1} ");
  int nums = Convert.ToInt32(Console.ReadLine());
  weightArr[weight] = nums; 
  weight++;
}
while(weight < size);

for(int i = 0; i < size; i++)
{
    if(weightArr[i] > maxweight)
    maxweight = weightArr[i];
}

Console.WriteLine($"The maxweight of weight is {maxweight}!");
}

MaxWeight();



// Взвешивание гирек, вторая самая тяжелая

void SecondMaxWeight()
{
int weight = 0;
int maxIndex = 0;

Console.WriteLine("How many weights you need weigh?");
int size = Convert.ToInt32(Console.ReadLine());
int[] weightArr = new int[size];
int maxweight = weightArr[0];
int secondMaxWeight = weightArr[0];


do
{
  Console.WriteLine($"Input the numbers of weight: {weight + 1} ");
  int nums = Convert.ToInt32(Console.ReadLine());
  weightArr[weight] = nums; 
  weight++;
}
while(weight < size);

for(int i = 0; i < size; i++)
{
    if(weightArr[i] > maxweight)
    {
        maxweight = weightArr[i];
        maxIndex = i;
    }
    
}

for(int i = 0; i < size; i++)
{
    if(i == maxIndex)
        {
            i++;
        }
    else if(weightArr[i] > secondMaxWeight)
        {
           secondMaxWeight = weightArr[i];          
        }
}

Console.WriteLine($"The maxweight of weight is {maxweight} and second maxweight is {secondMaxWeight}!");
}

SecondMaxWeight();


// Второй способ нахождения max и secondmax за один проход

void SecondMaxWeight()
{
Console.WriteLine("How many weights you need weigh?");
int size = Convert.ToInt32(Console.ReadLine());
int[] weightArr = new int[size];
int maxweight = weightArr[0];
int secondMaxWeight = weightArr[0];
int weight = 0;
int temp;



do
{
  Console.WriteLine($"Input the numbers of weight: {weight + 1} ");
  int nums = Convert.ToInt32(Console.ReadLine());
  weightArr[weight] = nums; 
  weight++;
}
while(weight < size); // Заполняем массив по одному элементу, пока срабатывает условие



for(int i = 0; i < size; i++)
{
    temp = maxweight;             // Записываем во временную переменную максимальное значение, чтобы при нахождении больше него, "бывшее" большее записать в secomdMax, и обновить max ! 

    if(weightArr[i] >= maxweight)
    {    
        maxweight = weightArr[i];
        secondMaxWeight = temp;
    }
    else if(weightArr[i] > secondMaxWeight)
        secondMaxWeight = weightArr[i]; 


     
}
Console.WriteLine($"The maxweight of weight is {maxweight} and second maxweight is {secondMaxWeight}!");
}

SecondMaxWeight();

//Повтороение пройденного материала
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

void MinMax ()
{
Console.WriteLine("Input first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if(firstNum > secondNum)
   Console.WriteLine($"The max number is {firstNum}, the min number is {secondNum}");
else Console.WriteLine($"The max number is {secondNum}, the min number is {firstNum}");   
}

MinMax();

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

void MinMax3 ()
{
Console.WriteLine("Input first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

if(firstNum > secondNum && firstNum > thirdNum)
   Console.WriteLine($"The max number is {firstNum}");
else if(secondNum > firstNum && secondNum > thirdNum) 
   Console.WriteLine($"The max number is {secondNum}");
else Console.WriteLine($"The max number is {thirdNum}");      
}

MinMax3();


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
void Even()
{
    Console.WriteLine("Input the number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num % 2 == 0)
        Console.WriteLine("This number is even!");
    else
        Console.WriteLine("This number is odd!");     
}

Even();


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

void EvenFrom1ToN (int num) // Рекурсивно
{
    if(num >= 2 && num % 2 == 0)
    {
        EvenFrom1ToN(num - 2);
        Console.Write(num + " ");    
    }
    
    else if(num >= 2 && num % 2 != 0)
    {
        num--;
        EvenFrom1ToN(num - 2);
        Console.Write(num + " ");   
    }   

}

Console.WriteLine("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
EvenFrom1ToN(num);


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

void SecondDigit ()
{
    Console.WriteLine("Input the three - digit number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int secondDigit = 0;

    if( num > 99 && num < 1000)
    {
        num = num / 10;
        secondDigit = num % 10;
        Console.WriteLine($"The second digit of number is {secondDigit}"); 
    }
    else Console.WriteLine("You input a not three digit number, please restart the program and inpun the three - digit number!");
}

SecondDigit();


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void ThreeDigitOfNumber () 
{

    Console.WriteLine("Input the three - digit number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int therdDigit = 0;

    if( num > 99)
    {
        while(num >= 1000)
        {
            num = num / 10;
        }
        therdDigit = num % 10;
        Console.WriteLine($"The three digit of number is: {therdDigit}");
    }
    else Console.WriteLine("The inputed number is not have therd digit!");
}

ThreeDigitOfNumber();


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Input the number day of the week: "); // Ниже эта же задача методом bool
int num = Convert.ToInt32(Console.ReadLine());
if(num == 6 || num == 7) Console.WriteLine("This day is holiday!");
else Console.WriteLine("This day is not holiday!");


bool Holiday(int num)
{
    if(num == 6 || num == 7) return true;
    else return false;
}

Console.WriteLine("Input the number of day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

if(Holiday(day) == true) Console.WriteLine("THis day is holiday!");
else Console.WriteLine("This day is not s holiday!");


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrom(int num)
{
    int tempNum = num;
    int newNum = 0;

    while (tempNum > 0)
    {
        newNum = newNum * 10 + tempNum % 10;
        tempNum = tempNum / 10;
    
    }

    if(num == newNum) return true;
    else return false;
}

Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(Palindrom(number) == true) Console.WriteLine("This number is a palindrome!");
else Console.WriteLine("This number is not a palindrome!");

// 2й вариант решения, через массив
void ShowArray(int[] array)
{
    int i = 0;
    int j = 0;
    while(i < array.Length)
    {
      Console.WriteLine($" element [{j + 1}] is {array[i]}");
      i++;
      j++;
    }
    
}

int[] ArrayFromNum() // Палиндром, через массив, метод создания массива заполненого цифрами числа
{   
    Console.WriteLine("Input the number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int tempNum = number;
    int size = 0;
    int i = 0;

    while (number > 0)
    {
        number = number / 10;
        size++;
    }

    int[] array = new int[size];
    
        while(tempNum > 0)
        {
            array[i] = number * 10 + tempNum % 10;
            tempNum = tempNum / 10;
            i++;
        }
    
    return array;
}


void InversAndCompairArrays(int[] array) // Метод инверсии массива и сравнения с изначальным
{
    int i, j;
    int[] inversArray = new int[array.Length];

    for(i = 0, j = array.Length - 1; j >= 0; i++, j--)
    {
        inversArray[j] = array[i];
    }

    bool isEqual = Enumerable.SequenceEqual(array, inversArray);                // Встроенная функция сравнения одномерных массивов
    if (isEqual == true) Console.WriteLine("This number is a palindrome!");
    else Console.WriteLine("This number is not a palindrome!");
}

int[] palArray = ArrayFromNum();
ShowArray(palArray);
InversAndCompairArrays(palArray);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

void Distans3D()
{
    Console.WriteLine("Input the coordinate X, first pixel: ");
    int numX1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the coordinate Y, first pixel: ");
    int numY1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the coordinate Z, first pixel: ");
    int numZ1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the coordinate X, second pixel: ");
    int numX2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the coordinate Y, second pixel: ");
    int numY2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the coordinate Z, second pixel: ");
    int numZ2 = Convert.ToInt32(Console.ReadLine());

    double distance = Math.Sqrt(Math.Pow(numX2 - numX1, 2) + Math.Pow(numY2 - numY1, 2) + Math.Pow(numZ2 - numZ1, 2));
    Console.WriteLine($"The distance between pixel 1 and pixel 2 is: {distance}");
}

Distans3D();


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void TableOfCube(int num) // Рекурсивно
{
    if(num >= 1)
    {
        TableOfCube(num - 1);
        Console.Write(Math.Pow(num, 3) + " ");
    } 
}

Console.WriteLine("Input the number: ");
int numN = Convert.ToInt32(Console.ReadLine());
TableOfCube(numN);


// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

void MathPow(int numA, int numB)
{
 int result = numA;

 while(numB > 1)
 {
    result = result * numA;
    numB--;
 }
 Console.WriteLine($"The result of MathPow is: {result}");    
}

Console.WriteLine("Input the number A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

MathPow(numA, numB);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void GetSumOfDigit()
{
    Console.WriteLine("Input the number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int temp = num;
    int sum = 0;

    while(temp > 0)
    {
        sum = sum + temp % 10;
        temp = temp / 10;
    }
    Console.WriteLine($"The sum of digits is: {sum}");
}

GetSumOfDigit();


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] randomArray = new int[size];
    for(int i = 0; i < size; i++)
    randomArray[i] = new Random().Next(minValue, maxValue);
    return randomArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine($"[{i}] {array[i]} ");
}

Console.WriteLine("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minValue of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maxValue of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);



// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateCustomArray()
{
    Console.WriteLine("Inpup the size of array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] customArray = new int[size];
    int numOfElement = 0;
    int nums = 0;
    int i = 0;

    while(size > 0)
    {
        Console.WriteLine($"Input three digits number for array filling, element {numOfElement} : ");
        nums = Convert.ToInt32(Console.ReadLine());

        if(nums < 100 || nums > 999) Console.WriteLine("You inputed a not 3 digits number, please input  the 3 digits number!");
        else
        {
            customArray[i] = nums;
            i++;
            numOfElement++;
            size--;      
        }
        
    }
    return customArray;
}


int NumOfEvenElements (int[] array)  // Метод проверки элементов массива на четность
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;
    return count;
}

int[] myArray = CreateCustomArray();
ShowArray(myArray);
int counter = NumOfEvenElements(myArray);
Console.WriteLine($"The number of even elements of array is: {counter}");


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray()
{
    Console.WriteLine("Input the size of array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the min value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the max value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for(int i = 0; i < array.Length - 1; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;    
}

void SumOddPosition(int[] array) 
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
        sum += array[i];

    Console.WriteLine($"The sum of element on odd position of array is {sum}");    
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
SumOddPosition(myArray);


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArrayRealNum()
{
    Console.WriteLine("Input the size of array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the min value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input the max value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
                   
    return array;    
}

void MinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double result = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if(array[i] < min) min = array[i];
    }
    result = max - min;
    result = Math.Round(result, 2);
    Console.WriteLine($"The differens between max and min elements of array is: {result}");
}

double[] myArray = CreateRandomArrayRealNum();
ShowArray(myArray);
MinMax(myArray);


// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PositiveNum()
{
    Console.WriteLine("How many numbers want you input?");
    int nums = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int num = 0;

    do
    {
        Console.WriteLine("Input the number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) 
        {
            count++;
        }
        nums--;
    }
    while(nums > 0);

    Console.WriteLine($"The numbers of positive is: {count} "); 
}

PositiveNum();

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

void PointInterspect()
{
    double x = 0;
    double y = 0;
    Console.WriteLine("Input the b1 number: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input the k1 number: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input the b2 number: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input the k2 number: ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    if(k1 == k2 && b1 == b2) Console.WriteLine("This lines coinside!");
    else if(k1 == k2) Console.WriteLine("This lines are parallel!");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"This lines ara interspect in point x: {x} y: {y}");
    }
}

PointInterspect();


// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] CreateRandom2DRealNumArray()
{
    Console.WriteLine("Input the number of rows of array: ");
    var rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the number of columns of array: ");
    var columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the min number of array elements: ");
    var min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the max number of array elements: ");
    var max = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
       for(int j = 0; j < columns; j++)
          array[i, j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);

    return array;
    
}

void Show2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
          Console.Write(array[i, j] + " ");
          Console.WriteLine();
    }
    Console.WriteLine();
}    

double[,] myArray = CreateRandom2DRealNumArray();
Show2DArray(myArray);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void Position(double[,] array)
{
    Console.WriteLine("Input index i for seach array element: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input index j for seach array element: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if(i > array.GetLength(0) || i < 0 || j > array.GetLength(1) || j < 0) 
      Console.WriteLine("The element of array does not exits!");
    else Console.WriteLine($"Element of array is: {array[i, j]}");  
}

double[,] myArray = CreateRandom2DRealNumArray();
Show2DArray(myArray);
Position(myArray);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/
int[,] CreateRandom2DArray()
{
    Console.WriteLine("Input the number of rows of array: ");
    var rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the number of columns of array: ");
    var columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the min number of array elements: ");
    var min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the max number of array elements: ");
    var max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
       for(int j = 0; j < columns; j++)
          array[i, j] = new Random().Next(min, max);

    return array;
    
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
          Console.Write(array[i, j] + " ");
          Console.WriteLine();
    }
    Console.WriteLine();
}
/*
void AverageOfArrayColumns(int[,] array)
{
    double average = 0;
    double sum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        average = Math.Round(sum / array.GetLength(0), 2);
        Console.Write(average + " ");
        sum = 0;
        
        
    }
}

int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
AverageOfArrayColumns(myArray);


// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
void SortArray(int[,] array)  // Метод преобразующий, поэтому можно делать его void и ничего не возвращать
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for(int j = 0; j < array.GetLength(1); j++)
           for(int k = j + 1; k < array.GetLength(1); k++)
            if(array[i, j] < array[i, k])
            {
               temp = array[i, j];
               array[i, j] = array[i, k];
               array[i, k] = temp;
            }
    }           
            
}

int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
SortArray(myArray);
Show2DArray(myArray);
/*
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

void ShowArray(int[] array) // Метод вывода массива в консоль
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($"sum elem of row: [{i + 1}] is {array[i]}"); 
    }
}

int[] SumRow(int[,] array)
{
    int[] rowsArray = new int[array.GetLength(0)];
    int sum = 0;
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
            rowsArray[i] = sum;
            index++;
    }
    return rowsArray;
}

void MinRow(int[] array)
{
    int indexOfmin = 0;
    int min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
       if(array[i] < min)
       {
       min = array[i];
       indexOfmin = i;
       }
    }
    
    Console.WriteLine($"The index of rows with minimal sum elements of array is: {indexOfmin + 1}");
}

int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
int[] newArray = SumRow(myArray);
ShowArray(newArray);
MinRow(newArray); 


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

void SortArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
            if (array[j] < array[i])
            {
                minPosition = j;
            }
        temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

Console.WriteLine("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the minimal value of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the maximum value of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
SortArray(myArray);
Console.WriteLine();
ShowArray(myArray);
*/