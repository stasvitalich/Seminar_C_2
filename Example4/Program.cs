//Программа, проверяющая, что введённое число
//одновременно без остатка делится на 7 и на 23

//Иниицируем ввод числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//Оборачиваем наш код в функцию 
void quotient () {

//Если число делится на 7 без остатка, то проверяем,
//в новом условии, делится ли оно на 23 без остатка 
if (number % 7 == 0) 
{   
    if (number % 23 == 0)
    {
        Console.WriteLine("Да");
    }
    
}
else
{
    Console.WriteLine("Нет");
}
}

//Выводим функцию
quotient ();
