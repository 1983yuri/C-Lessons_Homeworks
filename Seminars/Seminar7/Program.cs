
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

/*

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

// Задача 1 (Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.)

int[,] CreateSum2dArray() // Двумерный массив, сколько запятых столько мер
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++) // Пробегаем по всем строкам
        for(int j = 0; j < columns; j++) // Пробегаем по всем столбцам
            array[i, j] = i + j;      
    
    return array;
}

int[,] sumArray = CreateSum2dArray();
int[,] sumArray = CreateSum2dArray();
Show2dArray(sumArray);


// Задача 2 (Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты)
*/
void Quad2dArray(int[,] array) // Метод можно сделать void, как преобразующий
{
    for(int i = 0; i < array.GetLength(0); i += 2)
       for(int j = 0; j < array.GetLength(1); j += 2)
       {
            array[i, j] = array[i, j] * array[i, j]; // array[i,j] *= array[i,j];
       }
}

int[,] myArray = CreateRandom2dArray();
Console.WriteLine("Our random array is: ");
Show2dArray(myArray);
Console.WriteLine("New version of our array is:");
Quad2dArray(myArray);
Show2dArray(myArray);


// Задача 3 (Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)



int SumOfDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;    
} 

int arrayDiagSum = SumOfDiag(myArray);
Console.WriteLine(arrayDiagSum);


