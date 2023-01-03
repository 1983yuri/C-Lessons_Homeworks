// Рекурсия

// Задача1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num +" "); // В данном случае выводим на обратном пути, после погружения в рекурсию, если перенести вывод выше вызова функции, будет работать в 2х направлениях
}
}
ShowNums(5);
*/

// Задача2: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int GetSumOfDigits(int num)
{
    if(num != 0) return GetSumOfDigits(num / 10) + num % 10;
    else return 0;
}
Console.Write(GetSumOfDigits(417));
*/

// Задача3: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, M и N могут быть больше друг - друга
/*
void ShowDiff(int numA, int numB)
{
    if(numA < numB) 
    {  
        ShowDiff(numA, numB - 1);
        Console.Write( numB + " ");
    }
    if(numA > numB)
    { 
        Console.Write(numA + " ");
        ShowDiff(numA - 1, numB);
    }
    if(numA == numB) Console.Write(numA + " ");
}
Console.Write("Input a number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
ShowDiff(numM, numN);
*/


// Задача4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double Degree(int basic, int degree)
{
    if(degree > 0) return Degree(basic, degree - 1) * basic;
    else if(degree < 0) return Degree(basic, degree + 1) / basic;
    else return 1;
}
Console.WriteLine("Input a basic number");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a degree number");
int numB = Convert.ToInt32(Console.ReadLine());
double der = Degree(numA, numB);
Console.WriteLine($"{numA} raised to the power of {numB} is equal to {der}");
*/

int[,] CreateRandom2dArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задача1: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
void Reverse2dArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
}
Reverse2dArray(myArray);
Show2dArray(myArray);
*/

// Задача1: Задайте двумерный массив. Напишите программу, которая поменяет местами любые 2 строки массива.
/*
void CreateNewArray(int[,] array, int numA, int numB)
{
    if( numA != numB && numA >= 0 && numB >= 0 && numA < array.GetLength(0) && numB < array.GetLength(0))
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[numA,j];
            array[numA,j] = array[numB,j];
            array[numB,j] = temp;
        }
    }
    else Console.WriteLine("No row");
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine("Input first row");
int indA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second row");
int indB = Convert.ToInt32(Console.ReadLine());
CreateNewArray(myArray, indA, indB);
Show2dArray(myArray);
*/


// Задача1: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
int[] MinElement(int[,] array)
{
    int[] min = new int[2];
    int temp = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < temp)
            {
                temp = array[i,j];
                min[0] = i;
                min[1] = j;
            }
        }
    }
    return min;
}
int[,] CutArray(int[,] array, int minI, int minJ)
{
    int[,] cutArray = new int [array.GetLength(0)- 1, array.GetLength(1) - 1];
    for(int i = 0, x = 0; i < array.GetLength(0);i++, x++)
    {
        if(i != minI)
        {
            for(int j = 0, y = 0; j < array.GetLength(1);j++, y++)
            {
                if( j != minJ)
                {
                    cutArray[x,y] = array[i,j];
                }
                else y--;
            }
        }
        else x--;
    }
    return cutArray;
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[] minArray = MinElement(myArray);
int[,] cutNewArray = CutArray(myArray, minArray[0], minArray[1]);
Show2dArray(cutNewArray);
*/


