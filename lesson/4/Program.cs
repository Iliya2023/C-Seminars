﻿//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
// 
// int FindSum (int num)
// {
//     int sum = 0;
//     for (int current = 1; current <= num; current++)
//     {
//         sum += current;// sum = sum + current;
//     }
//     return sum;
// }

// Console.WriteLine ("Input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (FindSum (a));





//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
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





//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120
// 
// int Factorial (int num)
// {
//   int proizv = 1;
//   for (int current = 1; current <= num; current++)
//   {
//     proizv *= current;// sum = sum + current;
//   }
//   return proizv;
// }
// Console.WriteLine ("Input number:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (Factorial (a));





//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
// 
// int FindDigit (int num)
// {
//   int count = 1;
//   while (num > 10)
//   {
//     num = num/10;
//     count++;
//   }
//   return count;
// }
// Console.WriteLine("input number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindDigit(a));