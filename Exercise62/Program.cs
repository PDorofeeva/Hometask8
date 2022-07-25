/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
int[,] array = new int[4,4];
int p = 1;
for (int j = 0; j < array.GetLength(1); j++)
{
    array[0, j] = p;
    p++;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(i != 0)
        {
            array[i,array.GetLength(1) - 1] = p;
        }
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}