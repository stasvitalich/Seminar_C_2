//Инициализируем ввод случайного трёхзначного числа
int x = new Random ().Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное число {x}");

int firstDigit = x / 100;
Console.WriteLine($"Первая цифра: {firstDigit}");

int lastDigit = x % 10;
Console.WriteLine($"Последняя цифра: {lastDigit}");

int finalDigit = firstDigit * 10 + lastDigit;
Console.WriteLine($"Итоговая цифра: {finalDigit}");
