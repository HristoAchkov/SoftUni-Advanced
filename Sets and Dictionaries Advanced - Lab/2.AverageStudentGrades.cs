int entries = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();

for (int i = 0; i < entries; i++)
{
    string[] input = Console.ReadLine().Split();

    string name = input[0];
    decimal grades = decimal.Parse(input[1]);

    if (!dict.ContainsKey(name))
    {
        dict.Add(name, new List<decimal>());
    }
    dict[name].Add(grades);
}

foreach (var item in dict)
{
    Console.Write($"{item.Key} -> ");
    foreach (var grade in item.Value)
    {
        Console.Write($"{grade:f2} ");
    }
    Console.WriteLine($"(avg: {item.Value.Average():f2})");
}