//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

// Инициализируем ввод первого и второго числа:
Console.WriteLine("Введите число: ");

//Добавляем строки кода, 
//позволяющие на вход от пользователя 
//получить число больше 99
int number1 = int.Parse(Console.ReadLine());
if (number1 < 100)
{
    Console.WriteLine("Третьей цифры нет"); 
    return;
}

//При помощи цикла и деления,
//из любого числа получаем трёхзначное
while (number1 > 999)
{
    number1 = number1 / 10;
}

//При помощи оператора остатка получаем третью цифру в числе.
int result = number1 % 10;
Console.WriteLine($"Третья цифра введённого вами числа: {result}");
