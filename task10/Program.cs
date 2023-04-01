/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

task1();
void task1()
{
    Console.WriteLine("Введите число от 100 до 999:");
    int number = int.Parse(Console.ReadLine());
   // Console.WriteLine($"Вторая цифра числа { SecondNumber(number)} ");

if(number>999 )
System.Console.WriteLine("Вы ввели не трехзначное число");

    int SecondNumber(int number)
    {
        int secondnum = number / 10;
        int secondn = secondnum % 10;
        return secondn;

    }
   
Console.WriteLine($"Вторая цифра числа { SecondNumber(number)}");

 if( number <100)
{
    System.Console.WriteLine($"Вы ввели не трехзначное число");
}
}

