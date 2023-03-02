// 1  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8
// int BiggestDigit (int num)
// {
//   int ed = num % 10;
//   int dec = num / 10;

//   if(dec > ed) return dec;
//   else return ed;
// }
// int randomnum = new Random().Next(10, 100);
// int result = BiggestDigit(randomnum);
// Console.WriteLine ($"Bigges tDigit of {randomnum} -> {result}" );



// 2 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98
// int DeleteDigit (int num)
// {
//   int sot = num / 100;
//   int ed = num % 10;
//   return sot * 10 + ed;
// }
// int randomnum = new Random().Next(100, 1000);
// Console.WriteLine(randomnum);
// Console.WriteLine(DeleteDigit(randomnum));



//3. напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да
// bool KratNum(int num)
// {
//   return num % 7 == 0 && num % 23 == 0;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Your number {num} kratno 7 and 23? This is {(KratNum(num))}");



//4 напишите программу, которая на вход принимает два числа и проверяет, является ли одно число квадратом другого
// bool Quad(int num1, int num2)
// {
//   return num1 * num1 == num2 | num2 * num2 == num1;
// }
// Console.WriteLine("Input firt number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Your numbers {num1},{num2} are the squares one of one? This is {(Quad(num1, num2))}");



//5 напишите программу, которая будет принимать на вход два числа и выводить, является ли число кратом первому.
// Если второе число не кратно числу первому, то она выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно
// void KratNum (int num1, int num2)
// {
//   int res = num1 % num2;
//   if (res == 0) Console.WriteLine($"your number {num1} kратно {num2} ");
//   else Console.WriteLine($"your number {num1} не кратно {num2}, остаток {res}");
// }
// Console.WriteLine("Input firt number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// KratNum(num1, num2);