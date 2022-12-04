// Написать программу ,кот. на вход принимает тоехзначное  число и на выходе показывает вторую цифру этого числа

Console.WriteLine ("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100;
int c = b / 10;  
Console.WriteLine(c);
