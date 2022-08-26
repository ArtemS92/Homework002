Console.Clear();

Console.Write("Введите трехзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());


int result = (num % 100) / 10;
Console.WriteLine($"Второе число равно : {result}" );