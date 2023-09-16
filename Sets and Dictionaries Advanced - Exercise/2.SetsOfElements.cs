int[] entries = Console.ReadLine().Split().Select(int.Parse)
    .ToArray();
int n = entries[0];
int m = entries[1];

HashSet<int> setOne = new HashSet<int>();
HashSet<int> setTwo = new HashSet<int>();
HashSet<int> unique = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    setOne.Add(input);
}
for (int i = 0; i < m; i++)
{
    int input = int.Parse(Console.ReadLine());
    setTwo.Add(input);
}
foreach (var item in setOne)
{
    foreach (var check in setTwo)
    {
        if (item == check)
        {
            unique.Add(item);
        }
    }
}

foreach (var item in unique)
{
    Console.Write(item);
Console.Write(" ");
}