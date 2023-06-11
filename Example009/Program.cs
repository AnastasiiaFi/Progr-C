// Массивы

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int [] array = {11,21,31,14,15,16,71,81,19};

// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// ); 

// System.Console.WriteLine(max);


// int[] array = {1,2,3,4,9,43,23,1,2,9};

// int n = array.Length;
// int find = 9;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         System.Console.WriteLine(index);
//         break; //прерви цикл
//     }
//     index ++;
// }

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
int[] array = new int[10];

FillArray(array);
PrintArray(array); 
//Итог вывод 10 чисел случайным образом сгенерированные