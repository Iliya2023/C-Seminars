// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// 
// int[] CreateRandomArray(int size)
// { 
//     int[] newArray = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     { 
//         newArray[i] = new Random().Next(100, 1000); 
//     } 
//     return newArray; 
// } 
// void ShowArray(int[] array) 
// { 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         Console.Write(array[i] + " ");
//     } 
// } 
// int FindCountArray(int[] array) 
// { 
//     int count = 0; 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         if (array[i] % 2 == 0) 
//         { 
//             count++; 
//         } 
//     } 
//     return count; 
// } 
// Console.WriteLine("Input array size:"); 
// int size = Convert.ToInt32(Console.ReadLine()); 
// int[] array = CreateRandomArray(size);
// ShowArray(array); 
// Console.WriteLine($"-> {FindCountArray(array)}");






// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// 
// int[] CreateRandomArray(int size)
// { 
//     int[] newArray = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     { 
//         newArray[i] = new Random().Next(1, 10); 
//     } 
//     return newArray; 
// } 
// void ShowArray(int[] array) 
// { 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         Console.Write(array[i] + " ");
//     } 
// } 
// int FindSumArray(int[] array) 
// {
//   int sum = 0;
//   for (int i = 0; i < array.Length; i+=2)
//   sum = sum + array[i];
//   return sum;
// }
// Console.WriteLine("Input array size:"); 
// int size = Convert.ToInt32(Console.ReadLine()); 
// int[] array = CreateRandomArray(size);
// ShowArray(array); 
// Console.Write($" -> sum odd position {FindSumArray(array)}");
// Console.WriteLine();





//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// 
// double[] CreateRandomArray(int size)
// { 
//     double[] newNum = new double[size]; 
//     for (int i = 0; i < size; i++) 
//     { 
//         newNum[i] = new Random().Next(1, 1000);
//         newNum[i]/=100; 
//     } 
//     return newNum; 
// } 
// void ShowArray(double[] Num) 
// { 
//     for (int i = 0; i < Num.Length; i++) 
//     { 
//         Console.Write(Num[i] + " ");
//     } 
// } 
// double FindRaz(double[] Num)
// {
//   double min = Num[0];
//   double max = Num[0];
//   for (int i = 1; i < Num.Length; i++)
//   { 
//   if (max < Num[i])
//   max = Num[i];
//   if (min > Num[i])
//   min = Num[i];
//   }
//   return max-min;
// }
// Console.WriteLine("Input array size:"); 
// int size = Convert.ToInt32(Console.ReadLine()); 
// double[] Num = CreateRandomArray(size);
// ShowArray(Num); 
// Console.WriteLine();
// Console.WriteLine($"Difference -> {FindRaz(Num)}");
// Console.WriteLine();