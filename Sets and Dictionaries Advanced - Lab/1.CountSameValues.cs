List<double> list  = Console.ReadLine().Split().Select(double.Parse)
    .ToList();

Dictionary<double, int> result = new Dictionary<double, int>();

foreach (var item in list)
{
	if (!result.ContainsKey(item))
	{
		result.Add(item, 0);
	}

	result[item]++;
}

foreach (var item in result)
{
	Console.WriteLine($"{item.Key} - {item.Value} times");
}