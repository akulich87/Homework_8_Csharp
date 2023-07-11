// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Генерация массива
int[,] FillArray(int row, int col, int leftRange, int rightRange)
{
  int[,] tempArray =  new int[row, col];
  var rand = new Random();
  for (int i = 0; i < tempArray.GetLength(0); i++)
  {
    for (int j = 0; j < tempArray.GetLength(1); j++)
    {
      tempArray[i,j] = rand.Next(leftRange, rightRange + 1);
    }
  }
  return tempArray;
}

// Ввод данных
int[] ReadInt(string text)
{
 Console.Write(text);
 return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse); ;
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

// Сортировка элементов в строке по убыванию
void SortToLower(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int l = 0; l < array.GetLength(1) - 1; l++)
      {
        if(array[i,l] < array[i,l + 1])
        {
          int temp = array[i,l +1];
          array[i,l + 1] = array[i,l];
          array[i,l] = temp;

        }
      }
    }
  }
}

// ......................................
int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[,] array = FillArray(size[0], size[1], 0, 9);

PrintArray(array);

SortToLower(array);
System.Console.WriteLine();
PrintArray(array);