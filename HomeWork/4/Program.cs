﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int NatStep (int numA, int numB)
// {
//   int res = 1;
//   for (int i = 1; i <= numB; i++)
//   {
//     res = res * numA;
//   }
 
//  return res;
// }
// Console.WriteLine("Input number A ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{numA}, {numB} -> {(NatStep(numA, numB))}");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// 
// int SumNumber(int num)
//  {
//   int counter = Convert.ToString(num).Length;
//   int advance = 0;
//   int result = 0;
//   for (int i = 0; i < counter; i++)
//   {
//       advance = num - num % 10;
//       result = result + (num - advance);
//       num = num / 10;
//     }
//    return result;
//   }
// Console.Write("Input nnumber: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sumNumber = SumNumber(num);
// Console.WriteLine($"Sum  of the digit in number {num} -> {sumNumber}");





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// 
// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }
// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateRandomArray(size, minValue, maxValue));
