// Задача 19:Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// bool Palindrom(int num)
// { 
//   int num1 = num / 10000;
//   int num5 = num % 10;
//   int num2 = num / 1000 % 10; 
//   int num4 = num % 100 /10;  
//   return num1 == num5 && num2 == num4; 
// }
// Console.WriteLine("Input five-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 10000 || num >= 99999) Console.WriteLine($"your number {num} is not five-diget ");
// Console.WriteLine($"Your number {num} Palindrom? This is {Palindrom(num)}");


//     Console.WriteLine($"Yor number {num} -> palindrome ");
//   }
//   else 
//   {
//   Palindrom(num); 
//   }   
// }
// Console.WriteLine("Input five-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 10000 | num >= 99999 );
// Console.WriteLine($"Your number {num} is not five-digit!");





// Задача 21:Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//
// double FindDistance(double x1, double y1, double n1, double x2, double y2, double n2)
// {
// return Math.Round(Math.Sqrt (Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(n2-n1, 2)), 2);
// }
// Console.WriteLine("Input coordinate X of A point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console. WriteLine("Input coordinate Y of A point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console. WriteLine("Input coordinate N of A point: ");
// double n1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X of B point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of B point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate N of B point: ");
// double n2 = Convert.ToDouble(Console.ReadLine());
// double distance = FindDistance(x1, y1, n1, x2, y2, n2);
// Console.WriteLine($"Distance between A and B is {distance}");






// Задача 23:Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//
// void Power(double N)
// {
//   double i = 1;
//   while( i <= N)
//   {
//     Console.WriteLine($"{i}^3 -> {Math.Pow(i, 3)}");
//     i++;
//   }
// }
// Console.WriteLine("input number N: ");
// double N = Convert.ToDouble(Console.ReadLine());
// Power(N);
