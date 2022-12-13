
int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод создания и заполнения массива числами в заданном диапазоне
{
    int[] array = new int[size]; // Инициализации массива, выделение памяти

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  // +1 потому, что [)
    }
    return array; // Возвращаем просто имя массива!!!
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

 

void ShowArray(int[] array) // Метод вывода массива в консоль
{
    for(int i = 0; i < array.Length; i++)
    {
        
      Console.WriteLine($"array[{i + 1}] is {array[i]}"); //Рабочий вариант но не очень подходящий
    }
}

// Задача 1 (Найдите сумму отрицательных элементов массива)

/*
int SumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
           sum += array[i]; // sum = sum + array[i];

    return sum;
}


int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine($"Our array is: ");
ShowArray(myArray);
Console.WriteLine();
int sumNegativeResult = SumOfNegatives(myArray);
Console.Write($"The sum of negatives numbers in our array elements is: {sumNegativeResult}: ");



// Задача 2 (Напишите программу - замена элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот)


int[] Revers(int[] array)
{

    for(int i = 0; i < array.Length; i++)
    {
      array[i] = array[i] * -1;
    }
                  
    return array;
}


int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine($"Inputed array is: ");
ShowArray(myArray);
int[] newArray = Revers(myArray);
Console.WriteLine($"The new version of array is: ");
ShowArray(newArray);



// Задача 3 (Задайте одномерный массив из m случайных чисел, найдите количество элементов массива которые лежать в отрезке [a, b])

int SumIndexOfMinMax(int[] array, int a, int b)
{  
   int count = 0;           
   for(int i  = 0; i < array.Length; i++)
   {
      if(array[i] >= a && array[i] <= b)
         count++;
   }
   return count;
}


int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Our array is:");
ShowArray(myArray);


Console.Write("Input a min number of segment: ");
int a = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a max number of segment: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int result = SumIndexOfMinMax(myArray, a, b);
Console.WriteLine($"Number of elements in a given segment is: {result}");
*/

// Задача 4 (Найдите произведение пар чисел в одномерном массиве, парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве)

int[] MultPairs(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0)
       size++;               // Размер(длина) результирующего массива т.к. мы умножаем по 2 элемента, длина сократиться вдвое, если длина не четная, прибавляемк size 1

    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = array[i] * array[array.Length -1 - i]; // newArray[i] = array[0] * [array.Length -1]; - первое умножение 1-й на последний
    }
return newArray;
}

int[] myArray = CreateRandomArray(size, min, max);
int[] newArray = MultPairs(myArray);
Console.WriteLine("Our array is:");
ShowArray(myArray);
Console.WriteLine("New array is:");
ShowArray(newArray);