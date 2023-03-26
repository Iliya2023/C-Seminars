// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// 
// void ShowNumbers(int n)
// {
//   if (n >= 1)
//   {
//     Console.Write(n + " ");
//     ShowNumbers(n - 1);
//   }
// }
// Console.Write(" input number ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(n);
// Console.WriteLine();



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// 
// int FindSum(int m, int n)
// {
//   int res = m;
//   if (m == n)
//     return 0;
//   else
//   {
//     m++;
//     res = m + FindSum(m, n);
//     return res;
//   }
// }
// Console.Write("Input number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSum(m - 1, n));




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// 
// int Akkerman(int m, int n)
// {
//   if (m == 0)
//   {
//     return n + 1;
//   }
//   else if (n == 0 && m > 0)
//   {
//     return Akkerman(m - 1, 1);
//   }
//   else
//   {
//     return (Akkerman(m - 1, Akkerman(m, n - 1)));
//   }
// }
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" M = {m}, N = {n} -> A(m,n)={Akkerman(m, n)}");