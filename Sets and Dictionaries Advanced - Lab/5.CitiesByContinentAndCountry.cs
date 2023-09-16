Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

int entries = int.Parse(Console.ReadLine());
for (int i = 0; i < entries; i++)
{
    string[] input = Console.ReadLine().Split();

    string continent = input[0];
    string country = input[1];
    string city = input[2];

    if (!dict.ContainsKey(continent))
    {
        dict.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!dict[continent].ContainsKey(country))
    {
        dict[continent].Add(country, new List<string>());
    }
    dict[continent][country].Add(city);
}

foreach (var (continent,countries) in dict)
{
    Console.WriteLine($"{continent}:");
    foreach (var (country,cities) in countries)
    {
        Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
    }
}