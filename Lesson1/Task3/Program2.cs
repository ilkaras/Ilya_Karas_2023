List<int> numbers = new List<int>();
Console.WriteLine("Write you ten numbers");
for (int i = 0; i < 10; i++)
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
int eleventh;
List<int> changed = new List<int>();
Console.WriteLine("type eleventh number");
eleventh = Convert.ToInt32(Console.ReadLine());
foreach (int i in numbers)
{
    if ( i == eleventh)
    {
        changed.Add(i);
        changed.Add(eleventh);
    }
    else
    {
        changed.Add(i);
    }
}
foreach (int i in changed)
{
    Console.Write($"{i} ");
}
