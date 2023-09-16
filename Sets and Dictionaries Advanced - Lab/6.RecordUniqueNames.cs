HashSet<string> set = new HashSet<string>();

int entries = int.Parse(Console.ReadLine());

for (int i = 0; i < entries; i++)
{
    string name = Console.ReadLine();
    set.Add(name);
}
foreach (var item in set)
{
    Console.WriteLine(item);
}
