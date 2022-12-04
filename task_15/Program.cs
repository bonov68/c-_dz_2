//  Написать программу ,кот. на вход принимает цифру, кот. обозначает день недели и проверяет, явл. ли этот день выходным

Console.WriteLine ("Введите число от 1 до 7");
int d = Convert.ToInt32(Console.ReadLine());

if ( d == 6 || d == 7) 
{
    Console.WriteLine("выходной");
}
else 
{
    Console.WriteLine("рабочий день");
}

