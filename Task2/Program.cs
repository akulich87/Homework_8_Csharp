﻿// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Генерация массива
void FillRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Печать двумерного массива
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
}

// Вывод номера строки с наименьшей суммой элементов
void NumberRowMinSumElements(int[,] array)
{
  int minSumRow = 0;
  int minRow = 0;
  int sumRow = 0;
  for (int i = 0; i < array.GetLength(1); i++)
  {
    minRow += array[0,i];
  }
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sumRow += array[i,j];
      if(sumRow < minRow)
      {
        minRow = sumRow;
        minSumRow = i;
      }
      sumRow = 0;
    }
  }
  System.Console.Write($"Строка с наименьшей суммой элементов -> {minSumRow + 1}");
}

// ........................................
int[,] array = new int[4,4];
FillRandomArray(array);
PrintArray(array);
System.Console.WriteLine();
NumberRowMinSumElements(array);