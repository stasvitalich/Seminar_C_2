Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());

int result1 = numberOne / numberTwo;  
int result2 = numberTwo / numberOne;

if (numberOne > numberTwo)
{
    if (result1 == numberTwo)
    {
        Console.WriteLine("Да");
    }
     else
    {
        Console.WriteLine("Нет");
    }
}


if (numberTwo > numberOne)
{
    if (result2 == numberOne)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
