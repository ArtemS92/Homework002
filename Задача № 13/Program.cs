Console.Clear();

Console.Write("Введите число: "); 
string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.WriteLine($"Третья цифра : {numberArray[2]}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}