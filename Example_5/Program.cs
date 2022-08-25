﻿// Задача 48: Задайте двумерный массив 
// размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите 
// полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] matrixA = new int[m, n];
    for (int i = 0; i < matrixA.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < matrixA.GetLength(1); j++) // cтолбцы
        {
            matrixA[i, j] = i + j;
        }
    }
    return matrixA;
}

int[,] result = GetArray(rows, columns); 

void PrintArray (int [,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) 
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) 
        {
            Console.Write(inputMatrix[i,m] + "\t"); 
        }
        Console.WriteLine();
    }
}

PrintArray(result);

