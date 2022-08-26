Console.Clear();

Console.Write("Введите день недели: "); 
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine( "Выходной!");
}
else if (num >= 1 && num <= 5)
{
    Console.WriteLine( "Нет, не выходной!");
}
else 
{
    Console.WriteLine( "Такого дня недели не существует!");
}
