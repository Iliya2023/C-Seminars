// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 
// 
// double[,] Create2DRandomArray(int rows, int columns)
// {
//     double[,] myArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             myArray[i, j] = new Random().Next(-100, 100);
//             myArray[i, j]/=10;
//         }
//     }
//     return myArray;
// }
// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,]myArray = Create2DRandomArray(rows, columns);
// Show2DArray(myArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray(int rows, int columns)
// {
//   int[,] myArray = new int[rows, columns];
//   for (int i = 0; i < rows; i++)
//   {
//     for (int j = 0; j < columns; j++)
//     {
//       myArray[i, j] = new Random().Next(0, 100);
//     }
//   }
//   return myArray;
// }
// void Show2DArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }
// void FindMean(int[,] array, int n, int m)
// {
//   if (n > array.GetLength(0) || m > array.GetLength(1))
//   {
//     Console.WriteLine("такого элемента нет");
//   }
//   else
//   {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array[n - 1, m - 1]}");
//   }

// }
// Console.Write(" Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine()); //n
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine()); //m
// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(rows, columns);
// Show2DArray(myArray);
// FindMean(myArray, n, m);







// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// 
// int[,] Create2DRandomArray(int rows, int columns)
// {
//   int[,] myArray = new int[rows, columns];
//   for (int i = 0; i < rows; i++)
//   {
//     for (int j = 0; j < columns; j++)
//     {
//       myArray[i, j] = new Random().Next(0, 10);
//     }
//   }
//   return myArray;
// }
// void Show2DArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
//  }
// void FindAvarage (int[,] myArray, int rows, int columns)
// {
//   double avarage = 0;
//   for (int j = 0; j < myArray.GetLength(1); j++)
//   {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//       {
//         avarage = (avarage + myArray[i, j]);
//       }
//       avarage = avarage / rows;
//       Console.Write(avarage + " ; ");
//     }
 
// }
// Console.Write(" Введите количество строк "); 
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов "); 
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(rows, columns);
// Show2DArray(myArray);
// FindAvarage(myArray, rows, columns);
// Console.WriteLine(" "); 