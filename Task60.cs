/*
 Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
 Массив размером 2 x 2 x 2
 66(0,0,0) 25(0,1,0)
 34(1,0,0) 41(1,1,0)
 27(0,0,1) 90(0,1,1)
 26(1,0,1) 55(1,1,1)
 */

int[,,] array3D = new int[2, 2, 2];
GetArray(array3D);
PrintIndex(array3D);


// Функция для вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int t = 0; t < array3D.GetLength(2); t++)
            {
                Console.Write($"{array3D[i, j, t]}({i},{j},{t}) ");
            }
        }
    }
}

// Функция для заполнения 3D массива не повторяющимеся числами
void GetArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int t = 0; t < arr.GetLength(2); t++)
            {
                arr[t, i, j] += count;
                count += 3;
            }
        }
    }
}
