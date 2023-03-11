List<int> numbers = new List<int>();
Console.WriteLine("Write you ten numbers");
for (int i = 0; i < 10; i++)
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
int eleventh;
Console.WriteLine("type eleventh number");
eleventh = Convert.ToInt32(Console.ReadLine());
foreach (int i in numbers)
{
    if ( i == eleventh)
    {
        numbers.Add(eleventh);
        break;
    }
    else
        continue;
}
foreach (int i in numbers)
{
    Console.Write($"{i} ");
}