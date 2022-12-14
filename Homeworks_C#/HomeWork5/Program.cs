// Домашняя работа 5 // Методы создания и заполнения массива случайными числами и его вывод в консоль в начале

int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод создания и заполнения массива числами в заданном диапазоне
{
    int[] array = new int[size]; // Инициализации массива, выделение памяти

    for(int i = 0; i < size; i++)
    {          
        array[i] = new Random().Next(minValue, maxValue + 1);  // +1 потому, что [)    
    }
    return array; // Возвращаем просто имя массива!!!
}

 

void ShowArray(double[] array) // Метод вывода массива в консоль
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); 
    }
}

// Задача 1 (Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.)
/*
int EvenNum(int[] myArray) // Метод для определения четности элементов массива
{
   int count = 0; 
   for(int i = 0; i < myArray.Length; i++)
    {
      if(myArray[i] % 2 == 0)
         count++;
    }
return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min element of the array, a three-digit positive number: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max element of the array, a three-digit positive number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);


ShowArray(myArray);
int evnum = EvenNum(myArray); 

if(min < 100 || max > 999)
  Console.WriteLine("You inputed a numbers outside the required range!");
else
  Console.WriteLine($"The number of even elements in the array is: {evnum}");

// Задача 2 (Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях)

int OddSum (int[] myArray) // Метод подсчёта суммы элементов стоящих на нечетных позициях
{
    int oddsum = 0;
    
    for(int i = 1; i < myArray.Length; i += 2) // i = 1, потому, что договорились о нечетном индексе!
    {
        oddsum += myArray[i];       
    }
    return oddsum;
}   

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Our array is: ");
ShowArray(myArray);
int sumresult = OddSum(myArray);
Console.WriteLine($"The sum of odd array elements is {sumresult}");

// Задача 3 (Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива)
*/
double[] CreateRandomArrayRealNum(int size, int minValue, int maxValue) // Метод создания и заполнения массива вещественными числами в заданном диапазоне
{
    double[] array = new double[size];
    int[] arrayInt = new int[size]; 
    double[] arrayDouble = new double[size]; // Инициализации массива, выделение памяти под double массив

    for(int i = 0; i < size; i++)
    {          
        arrayInt[i] = new Random().Next(minValue, maxValue);  // +1 убрали потому, что верхняя граница double = 1
        arrayDouble[i] = new Random().NextDouble(); // NextDouble - не принимает аргументов
        array[i] = arrayInt[i] + arrayDouble[i];    
    }
    
    return array; 
}

double DiffMaxMin(double[] myArray)
{
    double diff = 0;
    double min = myArray[0];
    double max = myArray[0]; 
    for(int i = 0; i < myArray.Length; i++)
    {
        if(min > myArray[i])
           min = myArray[i];            
        else if(max < myArray[i])
           max = myArray[i];            
    }
        diff = max-min;
        
    return diff;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the min element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the max element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArrayRealNum(size, min, max);
Console.WriteLine("Our array is: ");
ShowArray(myArray);
double result = DiffMaxMin(myArray);
Console.WriteLine($"The difference between the max and min number in the array is: {result}");

