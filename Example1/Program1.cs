//Программа, которая выводит случайное число
//из отрезка [10, 99] и показывает наибольшую цифру этого числа
//78 -> 8

int x = new Random().Next(10, 100);
int x1 = x/10;
int x2 = x%10;
if (x1>x2) Console.WriteLine(x1);
else
{
    Console.WriteLine(x2);
}
Console.WriteLine(x);



