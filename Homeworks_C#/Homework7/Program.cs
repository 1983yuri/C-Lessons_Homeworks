// Домашняя работа 7

int[,] CreateRandom2dArray() // Двумерный массив, сколько запятых столько мер
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++) // Пробегаем по всем строкам
        for(int j = 0; j < columns; j++) // Пробегаем по всем столбцам
            array[i, j] = new Random().Next(minValue, maxValue + 1);      
    
    return array;
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

void ShowArray(double[] array) // Метод вывода массива в консоль
{
    for(int i = 0; i < array.Length; i++)
    {
        
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); //Рабочий вариант но не очень подходящий
    }
}

// Задача 1 (Задайте двумерный массив размером m×n, заполненный случайными вещественными числами)
/*
double [,] CreateRandomReal2dArray() // Двумерный массив, сколько запятых столько измерений
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        double[,] array = new double[rows, columns];
    
    for(int i = 0; i < rows; i++) // Пробегаем по всем строкам
        for(int j = 0; j < columns; j++) // Пробегаем по всем столбцам, когда пройдены все элементы в текущей строке
            array[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();      
    
    return array;
}

void ShowReal2dArray(double[,] array) // Метод вывода 2х мерного массива
{
    for(int i = 0; i < array.GetLength(0); i++) // Ноль по строкам, 1 по столбцам
    {
        for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


double[,] array = CreateRandomReal2dArray();
ShowReal2dArray(array);


// Задача 2 (Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет)

void NumOfElementArray(int[,] array)
{
    Console.WriteLine("Input the first index of array element: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the second index of array element: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if(i < array.GetLength(0) && j < array.GetLength(1))
       Console.WriteLine($"Element of inputed position is: {array[i, j]}");
    else 
       Console.WriteLine("This position does not exist!");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
NumOfElementArray(myArray);

*/
// Задача 3 (Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце)

double[] AverageColumns(int[,] array) 
{
    double[] average = new double[array.GetLength(1)];
    
    int index = 0;

    for(int j = 0; j < array.GetLength(1); j++) // Столбцы
    {
        int sumOfElem = 0;

        for(int i = 0; i < array.GetLength(0); i++) // Строки
                sumOfElem += array[i, j];  
            
        average[index] = (double) sumOfElem / array.GetLength(0); // Без (double) не работает
        index++;
    }          
        return average;
}

int[,] myArray = CreateRandom2dArray();
Console.WriteLine("Our random array is: ");
Show2dArray(myArray);
double[] averArray = AverageColumns(myArray);
Console.WriteLine("The average of columns is: ");
ShowArray(averArray);
