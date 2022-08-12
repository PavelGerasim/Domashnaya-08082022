Console.WriteLine("Введите первое натуральное число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int y = int.Parse(Console.ReadLine());
int length = 0;

if(x < y)
{
    length = y - x;
}
else
{
    if(x > y)
    {
        length = x - y;
    }
}
Console.WriteLine("Расстояние равно: ");
Console.WriteLine(length);