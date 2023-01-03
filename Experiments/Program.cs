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
*/

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