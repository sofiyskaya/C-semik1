﻿// Задача №11 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// положили в переменную рандомное трехзначное число
int num = new Random().Next(100,1000);
// напечатали число сгенерированное
Console.WriteLine("Случайное число - " + num);

// получим последнюю цифру числа
int lastDigit = num % 10;

// получим первую цифру числа
int firstDigit = num / 100;

// объединяем первую и последнюю цифру(умножаем первую на десять, чтобы были десятки и единицы, а не сумма первой и второй цифры)
num = firstDigit * 10 + lastDigit;
Console.WriteLine("Результат работы - " + num);

// можно заменить код в строках 8-15 одной строкой, но неоч удобно читать
// Console.WriteLine((num/100)*10 + (num%10));

