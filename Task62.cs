/*  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07   */

int len = 4;
int[,] massive = new int[len, len];
GetArraySpiral(massive, len);
PrintArray(massive);


//  Функция для заполнения массива по спирали начиная с 1
void GetArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int t = 0;
        do { array[i, j++] = value++; } while (++t < n - 1);
        for (t = 0; t < n - 1; t++) array[i++, j] = value++;
        for (t = 0; t < n - 1; t++) array[i, j--] = value++;
        for (t = 0; t < n - 1; t++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//  Функция для вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
