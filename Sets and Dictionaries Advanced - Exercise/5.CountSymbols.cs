string input = Console.ReadLine();
Dictionary<char, int> dict = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    char character = char.Parse(Console.ReadLine());
    if (!dict.ContainsKey(character))
    {
        dict.Add(character, 0);
    }
    dict[character] += 1;
}
foreach (var item in dict)
{
    Console.WriteLine(item);
}