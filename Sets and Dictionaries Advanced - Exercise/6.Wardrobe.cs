int entries = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < entries; i++)
{
    string[] input = Console.ReadLine()
        .Split(new string[] { " -> ", "," },StringSplitOptions.RemoveEmptyEntries);

    string color = input[0];
    if (!dict.ContainsKey(color))
    {
        dict.Add(color, new Dictionary<string, int>());
    }

    for (int j = 1; j < input.Length; j++)
    {
        string currentClothes = input[j];

        if (!dict[color].ContainsKey(currentClothes))
        {
            dict[color].Add(currentClothes, 0);
        }
            dict[color][currentClothes] += 1;
    }
}
string[] command = Console.ReadLine()
        .Split();
foreach (var color in dict)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var count in color.Value)
    {
        string print = $"* {count.Key} - {count.Value}";

        if (color.Key == command[0] && count.Key == command[1])
        {
            print += " (found!)";
        }

        Console.WriteLine(print);
    }
}