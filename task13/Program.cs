/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */



    Console.WriteLine("Введите число : ");
    int number=int.Parse(Console.ReadLine());


 if (number > 100 && number <1000)
{
    int result = number % 10;
    System.Console.WriteLine(result);
} 

if (number < 99)
{
    System.Console.WriteLine("Третьей цифры нет!");
}

else if (number >999)

{
    while (number > 999)
    {
       number= number /=10;
        int a = number % 10;
            
System.Console.WriteLine($"Третья цифра {a}");
}
}

 

/* int CetNum(int number);
{ 
while (number < 1000)
{
       number= number /=10;
}
return number % 10;
}
System.Console.WriteLine("{GetNum}");
} */