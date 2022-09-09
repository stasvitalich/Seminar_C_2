Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());

int result = numberOne % numberTwo;

if (result == 0) Console.WriteLine("Кратно");
else
{
    Console.WriteLine($"Не кратно, остаток {result}");
}
