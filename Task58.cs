/*   Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
 Например, даны 2 матрицы:
 2 4 | 3 4
 3 2 | 3 3
 Результирующая матрица будет:
 18 20
 15 18    */


int[,] firstarray = new int[2, 2];
int[,] secondArray = new int[2, 2];
int[,] resultArray = new int[2, 2];

GetArrayRandom(firstarray);
PrintArray2D(firstarray);

Console.WriteLine();

GetArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

void PrintArray2D(int[,] array);
if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);

// Функция для заполнения массива рандомными числами от -10 до 10
void GetArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
}

