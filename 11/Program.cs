/*  11 Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98  */

Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 100;
int a3 = num % 10;
int result = a1 * 10 + a3;
//Console.WriteLine($"двухнчное число из {num} -> {result}");

Console.WriteLine($"двухнчное число из {num} -> {a1}{a3}");
