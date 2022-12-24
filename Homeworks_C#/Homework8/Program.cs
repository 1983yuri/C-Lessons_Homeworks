// Домашняя работа 8
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

// Задача 1 (Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива)

void RowsMaxMin (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)    // Строки
    {
        int temp = 0;
        for(int j = 0; j < array.GetLength(1); j++) // Столбцы
           for(int k = j + 1; k < array.GetLength(1); k++)
                if(array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
    }       
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
RowsMaxMin(myArray);
Show2dArray(myArray);