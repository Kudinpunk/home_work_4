/*
Составить частотный словарь элементов двумерного массива. Частотный 
словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 9, 9, 0,
2, 8, 0, 9
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/

int [,] Create_array (int user_rows, int user_colimns, int min_value, int max_value)
{
    int [,] new_create_array = new int[user_rows, user_colimns];

    for (int i = 0; i < user_rows; i++)
    {
        for (int j = 0; j < user_colimns; j++)
        {
            new_create_array[i, j] = new Random().Next(min_value, max_value);
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

void Find_number (int [,] n_array, int max_value)
{
    int count_number = 0;
    int result = 0;
    while (count_number < max_value)
    {
        for (int i = 0; i < n_array.GetLength(0); i++)
        {
            for (int j = 0; j < n_array.GetLength(1); j++)
            {
                if (n_array[i, j] == count_number)
                {
                    result += 1;
                }
            }
        }
        if (result != 0)
        {
            Console.WriteLine($"{count_number} встречается {result} раз");
        }
        result = 0;
        count_number++;
    }
}

Console.Write("input count of rows: ");
int count_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input count of colimns: ");
int count_colimns = Convert.ToInt32(Console.ReadLine());
Console.Write("input min value greater than or equal to 0: ");
int min_v = Convert.ToInt32(Console.ReadLine());
Console.Write("input max value: ");
int max_v = Convert.ToInt32(Console.ReadLine());

int [,] user_array = Create_array(count_rows, count_colimns, min_v, max_v);
Show_array(user_array);
Find_number(user_array, max_v);
