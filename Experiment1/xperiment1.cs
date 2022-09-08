﻿//TASK10
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

// Инициализируем ввод первого и второго числа:
Console.WriteLine("Введите трёхзначное число: ");


//Добавляем строки кода, 
//позволяющие на вход от пользователя 
//получить число в диапазоне от 100 до 999
int number1 = int.Parse(Console.ReadLine());
if (number1 > 999)
{
    Console.WriteLine("Вы ввели слишком большое число, попробуйте снова"); 
    return;
}

if (number1 < 100)
{
    Console.WriteLine("Вы ввели слишком маленькое число, попробуйте снова"); 
    return;
}

//Через деление выводим вторую цифру числа
int var = number1 / 10;
int result = var % 10;
Console.WriteLine($"Вторая цифра введённого вами числа: {result}");
