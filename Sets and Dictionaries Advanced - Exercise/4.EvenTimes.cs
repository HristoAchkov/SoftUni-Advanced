int entries = int.Parse(Console.ReadLine());
Dictionary<int, int> dict = new Dictionary<int, int>();

for (int i = 0; i < entries; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!dict.ContainsKey(number))
    {
        dict.Add(number, 0);
    }
    dict[number] += 1;
}
foreach (var item in dict)
{
    if (item.Value % 2 == 0)
    {
        Console.WriteLine(item.Key);
    }
}
