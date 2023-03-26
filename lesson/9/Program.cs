//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
// 
// void ShowNumbers(int n)
// {
//     if(n>=1)
//     {
//         //Console.Write(n+" ");
//         ShowNumbers(n-1);
//         Console.Write(n+" ");
//     }
// }
// ShowNumbers(5);




//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
// 
// int FindSum (int num)
// {
//     if(num>0)
//     {
//         return FindSum(num/10) + num%10;
//     }
//     else
//     return num;
// }
// Console.WriteLine(FindSum(377));




//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"
// 
// void ShowNumbers(int m, int n)
// {
//     if (n != m)
//     {
//         if (n > m)
//         {
//             // Console.Write(n + " ");
//             ShowNumbers(m, n - 1);
//             Console.Write(n + " ");
//         }
//         else   
//         {
//             Console.Write(n + " ");
//             ShowNumbers(m, n + 1);
//             // Console.Write(n + " ");
//         }
//     }
//     else
//         Console.Write(n + " ");
// }
// ShowNumbers(5,1);





//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8
// 
// int FindStepen(int a, int b)
// {
//     if (b > 1)
//     {
//         return FindStepen(a, b-1) * a;
//     }
//     else
//         return a;
// }
// Console.WriteLine(FindStepen(2,3));