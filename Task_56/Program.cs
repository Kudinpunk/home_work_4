/* 
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int [,] Create_array (int user_rows, int user_colimns)
{
    int [,] new_create_array = new int[user_rows, user_colimns];

    for (int i = 0; i < user_rows; i++)
    {
        for (int j = 0; j < user_colimns; j++)
        {
            new_create_array[i, j] = new Random().Next(0, 10);
        }
    }
    return new_create_array;
}

void Show_array (int [,] show_array)
{
    for (int i = 0; i < show_array.GetLength(0); i++)
    {
        for (int j = 0; j < show_array.GetLength(1); j++)
        {
            Console.Write(show_array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [] Sum_of_rows (int [,] count_array, int count_rows)
{
    int [] sum_rows = new int[count_rows];
    for (int i = 0; i < count_array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < count_array.GetLength(1); j++)
        {
            sum += count_array[i, j];
        }
        sum_rows[i] = sum; 
    }
    return sum_rows;
}

void Number_of_rows_min_cum (int [] array)
{
    int index_number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[index_number])
        {
            index_number = i;
        }
    }
    Console.WriteLine($"row number with the smallest sum of elements: {index_number + 1}");
}

Console.Write("input count of rows: ");
int count_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input count of colimns: ");
int count_colimns = Convert.ToInt32(Console.ReadLine());

int [,] new_user_array = Create_array(count_rows, count_colimns);

if (count_colimns == count_rows)
    Console.WriteLine("input count of rows unequal count of colimns!");
else
{
    Console.WriteLine();
    Show_array(new_user_array);
    Number_of_rows_min_cum(Sum_of_rows(new_user_array, count_rows));
}



