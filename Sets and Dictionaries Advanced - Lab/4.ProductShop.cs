Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

string command = Console.ReadLine();

while (command != "Revision")
{
    string[] input = command.Split(", ");

    string name = input[0];
    string product = input[1];
    double price = double.Parse(input[2]);

    if (!dict.ContainsKey(name))
    {
        dict.Add(name, new Dictionary<string, double>());
    }

    if (!dict[name].ContainsKey(product))
    {
        dict[name].Add(product, 0);
    }

    dict[name][product] = price;

    command = Console.ReadLine();
}

dict = dict.OrderBy(x => x.Key).ThenBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

foreach (var (shop, products) in dict)
{
    Console.WriteLine($"{shop}->");
    foreach (var (product, price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}