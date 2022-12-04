// Написать программу ,кот. выводит третью цифру заданного числа или сообщает, что этой цифры нет

Console.WriteLine ("Введите любое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("такой цифры нет");  
}
else {
    while (a > 999)
    {
        a = a / 10;
        Console.WriteLine(a);
    }
    int b = a %10;
Console.WriteLine(b);
}



