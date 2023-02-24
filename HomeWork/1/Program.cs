// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// 
// Console.WriteLine("input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 > num2)
// {
//   Console.WriteLine($"first number {num1} is more of second number {num2}");
// }
// if(num1 < num2)
// {
//   Console.WriteLine($"first number {num1} is less of second number {num2}");
// }
// if(num1 == num2)
// {
//   Console.WriteLine($"first number {num1} is equals of second number {num2}");
// }




// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input  number ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if(num1 > max) 
// {
//   max = num1;
// }  
// if(num2 > max) 
// {
//   max = num2;
// }
// if(num3 > max) 
// {
//   max = num3;
// }
// Console.Write("Number MAX = ");
// Console.WriteLine(max);




// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// 
// Console.WriteLine("input number ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num %2 == 0)
// {
//   Console.WriteLine($"your number {num} is even" );
// }
// else
// {
//   Console.WriteLine($"your number {num} is not even" );
// }




// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// 
// Console.WriteLine("input N ");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = 1;
// while(current <= n)
// {
//   if (current %2 == 0)
//   Console.Write(current + " ");
//   current++;
// }      