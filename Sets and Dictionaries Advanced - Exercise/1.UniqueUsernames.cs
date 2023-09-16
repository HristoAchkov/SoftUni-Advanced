int entries = int.Parse(Console.ReadLine());

HashSet<string> set = new HashSet<string>();

for (int i = 0; i < entries; i++)
{
    string name = Console.ReadLine();

    set.Add(name);
}
foreach (var item in set)
{
    Console.WriteLine(item);
}