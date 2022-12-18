int[] array = { 1, 18, 31, 4, 15, 16, 17, 18 };

int n = array.Length; // Длина массива
int find = 18;        // Искомое значение   

int index = 0;        // Начальная позиция

while (index < n)
{
    if (array[index] == find)
    {
     Console.WriteLine(index);
     break;   
    }
    // index = index +1;
    index++;
}