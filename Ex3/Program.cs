﻿Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++){
    Console.WriteLine($"{i} = {i * i * i}");
}