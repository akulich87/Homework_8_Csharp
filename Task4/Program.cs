// Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);

// Заполнение 3D массива
void FillArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int l = 0; l < array.GetLength(2); l++) 
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j, l] = new Random().Next(10, 100);
      }
    }
  }
}

// Вывод индексов 3D массива
void PrintIndex(int[,,] array)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int l = 0; l < array3D.GetLength(2); l++)
    {
      System.Console.WriteLine();
      for (int j = 0; j < array3D.GetLength(1); j++)
      {
        System.Console.Write($"{array3D[i,l,j]} ({l},{j},{i}) ");
      }
    }
  }
}