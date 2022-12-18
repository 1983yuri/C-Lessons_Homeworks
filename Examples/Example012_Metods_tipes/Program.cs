/*
// Вид 1 
void Method1()
{
    Console.WriteLine("Autor: Arkhipov Y.V.");
}
Method1(); // Так вызывается метод такого типа

// Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);  
}
Method2("Text of the message"); // Так вызывается метод такого типа
// Будет отображать в консоли текст сообщения который мы указали при вызове метода
// Аргументов может быть несколько, ниже рассмотрим такой вариант
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; // Инкримент, если i-- декремент
    }
      
}
Method21("New message", 4); // Сообщение выведется 4 раза
Method21(msg: "New message", count: 4);// Можем при вызове метода явно указывать имена аргументовб при этом без разницы в каком порядке, ведь они с именами

// Вид 3 
int Method3() // Ничего не принимает
{
    return DateTime.Now.Year; // Считывает из системы год
}

int year = Method3(); // Вызываем метод, результат его работы записываем в перем. year
Console.WriteLine(year);


// Вид 4
string Method4(int count, string text) // Будем строку "text" компоновать count раз
{
   int i = 0;
   string result =  String.Empty; // String.Empty - присваем значение - пустая строка
   while(i < count)
   {
    result = result + text;
    i++;
   }
   return result;
}
string res = Method4(10, "qwerty"); // аргументы можно менять местами. Тут текст выведется 10 раз
Console.WriteLine(res);

Второй вариант 4-го Вида метода с использованием цикла for

string Method4(int count, string text) // Будем строку "text" компоновать count раз
{
   string result =  String.Empty; // String.Empty - присваем значение - пустая строка
   for(int i = 0; i < count; i++)
   {
    result = result + text;
   }
   return result;
}
string res = Method4(10, "qwerty"); // Аргументы можно менять местами. Тут текст выведется 10 раз
Console.WriteLine(res);


Цикл в цикле, пример(вывод таблицы умножения на экран)

for(int i = 2; i <= 10; i++) // Таблица умножения начинается с 2 и заканчивается на 10, счетчик i
{
    for(int j =2; j <= 10; j++)// Новый счетчик j
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(); // После выполнения тела цикла, делаем переход на новую строку
}

// === Отрабатываем ЦИКЛ for, работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
//              s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // Инициализация пустой строки

    int lenght = text.Length; // Узнаем длину нашей строки
    for (int i = 0; i < lenght; i++) // Пробегаемся от начала до конца нашей строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);


// Алгоритм сортировки методом выбора, или алгоритм сортировки методом min/max
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значеием первой неотсортированной позиции
// 3. Повторять пока есть неотсортированные элементы

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array) // Метод который печатает наш массив
{
    int count = array.Length;

    for (int i = 0; i < count; i++) // Пробегаем по всем эелементам нашего массива
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // Метод который упорядочевает наш массив
{
    for (int i = 0; i < array.Length -1; i++) // Проходимся по всем элементам нашего массива(array.Lenght -1 чтобы количество элементов совпало) 
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++) // Цикл внутри циклаб пробегаем по массиву j= i+1 потому, что первая позиция уже отсортирована
        {
            if(array[j] < array[minPosition]) 
            {
                minPosition = j; // Ищем минимальный элемент
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

Эта же задача, которая формирует массив в обратную сторону т.е. от максимального к минимальному
*/
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // Метод который печатает наш массив
{
    int count = array.Length;

    for (int i = 0; i < count; i++) // Пробегаем по всем эелементам нашего массива
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // Метод который упорядочевает наш массив
{
    for (int i = 0; i < array.Length - 1; i++) // Проходимся по всем элементам нашего массива(array.Lenght -1 потому, что первый элемент уже отсортирован) 
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++) // Цикл внутри циклаб пробегаем по массиву j= i+1 потому, что первая позиция уже отсортирована
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j; // Ищем минимальный элемент
            }
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);