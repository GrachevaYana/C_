/*  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 В итоге получается вот такой массив:
 7 4 2 1
 9 5 3 2
 8 4 4 2   */

int[,] table = new int[3, 4];
ArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);


// Функция заполнения массива рандомно числами от 1 до 9
void ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция для сортировки по убыванию элементов двумерного массива
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(1) - 1; t++)
            {
                if (array[i, t] < array[i, t + 1])
                {
                    int temp = array[i, t + 1];
                    array[i, t + 1] = array[i, t];
                    array[i, t] = temp;
                }
            }
        }
    }
}

// Функция для вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



