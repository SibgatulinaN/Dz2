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
    

    if (number > 100 && number <= 999)
    
    {
        int secondnum = number / 10;
        int secondn = secondnum % 10;
      



        Console.WriteLine($"Вторая цифра числа {secondn}");
    }
   
    else
    {
        System.Console.WriteLine($"Вы ввели не трехзначное число");
    }
}

