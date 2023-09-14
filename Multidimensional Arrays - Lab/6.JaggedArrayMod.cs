int n = int.Parse(Console.ReadLine());

int[][] jagged = new int[n][];
for (int row = 0; row < jagged.Length; row++)
{
    jagged[row] = Console.ReadLine().Split().Select(int.Parse)
        .ToArray();
}

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] tokens = command.Split();
    int rows = int.Parse(tokens[1]);
    int cols = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);
    bool isValid = true;

    if (rows < 0 || jagged.Length <= rows)
    {
        isValid = false;
    }
    else if (cols < 0 || jagged[rows].Length <= cols)
    {
        isValid = false;
    }
    if (isValid)
    {
        if (tokens[0] == "add")
        {
            jagged[rows][cols] += value;
        }
        else if (tokens[0] == "subtract")
        {
            jagged[rows][cols] -= value;
        }
    }
    else
    {
        Console.WriteLine("Invalid coordinates");
    }
    command = Console.ReadLine().ToLower();
}

for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write($"{jagged[i][j]} ");
    }
    Console.WriteLine();
}