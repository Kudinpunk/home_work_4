/*
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] Create_array ()
{
    Console.Write("input count of rows: ");
    int count_rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of colimns: ");
    int count_colimn = Convert.ToInt32(Console.ReadLine());

    int [,] new_array = new int [count_rows, count_colimn];

    for (int i = 0; i < count_rows; i++)
    {
        for (int j = 0; j < count_colimn; j++)
        {
            new_array[i, j] = new Random().Next(0, 10);
        }
    }
    return new_array;
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

int [,] Sort_array (int [,] random_array)
{
    for (int i = 0; i < random_array.GetLength(0); i++)
    {
        for (int j = 0; j < random_array.GetLength(1); j++)
        {
            for (int k = 0; k < random_array.GetLength(1) - 1; k++)
            {
                if (random_array[i, k] > random_array[i, k + 1])
                {
                    int temp_min = random_array[i, k + 1];
                    random_array[i, k + 1] = random_array[i, k];
                    random_array[i, k] = temp_min;
                }
            }
        }
    }
    return random_array;
}

int [,] array = Create_array();
Console.WriteLine();
Show_array(array);
int [,] sort_array = Sort_array(array);
Show_array(sort_array);
