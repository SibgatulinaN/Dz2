/* Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число дня недели : ");
int number = int.Parse(Console.ReadLine());

if ( number >5 && number < 8)
{
    Console.WriteLine("УРА! Выходной, не работать!");
}
else if (  number < 6 )
{
    System.Console.WriteLine("Работать!!! не выходной");
}
else if ( number >7)
System.Console.WriteLine(" Такой цифры, обозачающей день недели нет!");