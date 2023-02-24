// Console.WriteLine("Hello!");
// //int a; a = 5; 
// //Console.WriteLine(a);
// //Console.WriteLine("input number b");
// int b = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine($"you input this number -> {b} ");   //Console.WriteLine("you input this number -> " + b);
// //Console.WriteLine($"quad of {b} -> {b * b} ");
// int quad = b * b;
// Console.WriteLine(quad);



// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.WriteLine("input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num2 * num2 == num1)
// {
//   Console.WriteLine($"first number {num1} is quad of second number {num2}");
// }
// else
// {
//   Console.WriteLine($"first number {num1} is not quad of second number {num2}");
// }


// напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4 -3 -2 -1 0 1 2 3 4"
//2 -> "-2 -1 0 1 2"
// Console.WriteLine("input N ");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = n * (-1);
// while(current <= n)
// {
//   Console.Write(current + " ");
//   current++;
// }      


//  напишите программу, которая принимает на вход одно число и на выходе показывает "посдеднюю" цифру этого числа.
// 456 ->  6
// 782 ->  2
// 918 ->  8
// Console.WriteLine("input three-digiy numbers ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100 && num <= 999)
// {
//   int remainder = num %10;
//   Console.WriteLine($"last digit of {num} -> {remainder}" );
// }
// else
// {
//   Console.WriteLine("your input not three-digit number");
// }