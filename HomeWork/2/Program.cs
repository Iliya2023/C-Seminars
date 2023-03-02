// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// int SecondNumber (int num)
// {
//   int set = num / 10;
//   int des = set %10;
//   return des; 
// }
// Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 999 || num < 100) 
// {
//   Console.WriteLine($"yout number {num} is not three-digit number");
//   return;
// }
// Console.WriteLine($"yout second number in three-digit number {num} -> {SecondNumber(num)}");



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// int ThreeNumber (int num)
// {
//    int sot = num / 100;
//    int res = sot % 10;
//    return res;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num < 100) 
// {
//   Console.WriteLine($"в числе {num} третьей цифры нет");
//   return;
// }  
// Console.WriteLine(ThreeNumber(num));




// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// void Week (int num)
// {
//   if (num > 7) Console.WriteLine($"{num} не является днем недели");
//   if ( num > 5 && num <= 7) Console.WriteLine($" {num} -> yes");
//   else Console.WriteLine($" {num} -> no ");
//   }
// Console.WriteLine("Input number 1-7");
// int num = Convert.ToInt32(Console.ReadLine());
// Week(num);