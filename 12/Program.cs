/* Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если второе число не кратно числу первому,
то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно */

Console.Clear();
int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
if(a1 % a2 ==0)
{
    Console.WriteLine($"{num}, {a1} Кратно {a2}");
}else
{
    Console.WriteLine($"Число {num},{a1 } Не кратно {a2} остаток {a1 % a2}");
}

/* решение кирилла. неправильно прочитал задание
Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0){
    Console.WriteLine("кратно");}
else{
    Console.WriteLine($"не кратно, остаток - {num1 % num2}");
}   
*/