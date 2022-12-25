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


int[,] CreateCustom2dArray() // Метод создания и заполнения матрицы(2х мерного массива)
{
    
    Console.Write("Input a number of rows matrix : ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums matrix: ");
    int columns = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++) // Пробегаем по всем строкам
        for(int j = 0; j < columns; j++) // Пробегаем по всем столбцам
        {
            Console.WriteLine($"Input the number of matrix element of index [row {i + 1} , column {j + 1}]: ");
            int num = Convert.ToInt32(Console.ReadLine());
            array[i, j] = num;
        }
                 
    
    return array;
}

// Задача 1 (Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива)
/*
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


// Задача 2 (Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов)

void RowsMinSum(int[,] rowSum)
{
    int index = 0;                                    // Считаем суммы строк 
    int[] rowsSum = new int[rowSum.GetLength(0)];

    for (int i = 0; i < rowSum.GetLength(0); i++)     // Строки
    {
        int tempSum = 0;

        for (int j = 0; j < rowSum.GetLength(1); j++) // Столбцы
        {
            tempSum += rowSum[i, j];
        }
        rowsSum[index] = tempSum;
        index++;
    }

    int indexOfMin = 0;                               // Находим индекс строки с  минимальной суммой
    int min = rowsSum[indexOfMin];

    for (int i = 0; i < rowsSum.Length; i++)
    {
        if (min > rowsSum[i])
        {
            min = rowsSum[i];
            indexOfMin = i;
        }
    }
    Console.WriteLine($"The number of row minimum sum of element is: {indexOfMin + 1}"); // + 1 Потому, что выводим для пользователя а не по индексу!
}



int[,] myArray = CreateRandom2dArray();
Console.WriteLine("Our random array is:");
Show2dArray(myArray);
RowsMinSum(myArray);
*/

// Задача 3 (Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц)

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multMatrix = new int[,];
    
}

int[,] matrix1 = CreateCustom2dArray();
int[,] matrix2 = CreateCustom2dArray();
Console.WriteLine($"Our custom matrix 1 is: ");
Show2dArray(matrix1);
Console.WriteLine($"Our custom matrix 2 is: ");
Show2dArray(matrix2);




