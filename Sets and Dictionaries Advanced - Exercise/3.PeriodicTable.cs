using System.Security.Cryptography.X509Certificates;

SortedSet<string> SortedSet = new SortedSet<string>();

int entries = int.Parse(Console.ReadLine());

for (int i = 0; i < entries; i++)
{
    string[] input = Console.ReadLine().Split();
	for (int j = 0; j < input.Length; j++)
	{
		SortedSet.Add(input[j]);
	}
}
foreach (var item in SortedSet)
{
	Console.Write(item);
	Console.Write(" ");
}