Console.Clear();
int num = new Random().Next(10, 100);
int a1 = num / 10; // находим первую цифру из двухзначного числа
int a2 = num % 10; // находим остаток двухзначного числа, т.е вторую цифру
int max = a1;
if(max < a2)
  max = a2;
Console.WriteLine($"Максимальная цифра числа {num} -> {max}");