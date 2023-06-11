//Массивы, продолжение

void FillArray(int[] collection) //Метод формирования чисел случайным образом
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //Метод вывода числе
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[]collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //Принятое обозначение, чтобы если нет числа, то выдавалось -1, а не 0 позиция.

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index; 
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[4] = 4;
PrintArray(array); 
System.Console.WriteLine();

int pos = IndexOf(array, 44);
System.Console.WriteLine(pos);