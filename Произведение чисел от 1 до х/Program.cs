Console.WriteLine("Введите крайнее число: ");
int x = int.Parse(Console.ReadLine());
int count = 1;
int final = 1;

while(count <= x)
{
    final = final * count;
    count++;
}
Console.WriteLine(final);