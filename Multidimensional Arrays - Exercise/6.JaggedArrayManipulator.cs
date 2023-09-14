int rows = int.Parse(Console.ReadLine());

int[][] jagged = new int[rows][];

for (int row = 0; row < jagged.Length; row++)
{
    jagged[row] = Console.ReadLine().Split().Select(int.Parse)
    .ToArray();
}

string command = Console.ReadLine().ToLower();
for (int row = 0; row < jagged.Length - 1; row++)
{
    if (jagged[row].Length == jagged[row + 1].Length)
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] *= 2;
            jagged[row + 1][col] *= 2;
        }
    }
    else if (jagged[row].Length != jagged[row + 1].Length)
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] /= 2;
        }
        for (int col = 0; col < jagged[row + 1].Length; col++)
        {
            jagged[row + 1][col] /= 2;
        }
    }
}

while (command != "end")
{
    string[] info = command.Split();
    if (info[0] == "add")
    {
        int row = int.Parse(info[1]);
        int col = int.Parse(info[2]);
        int value = int.Parse(info[3]);
        if (jagged.Length > row && row >= 0) 
        {
            if (jagged[row].Length > col && col >= 0)
            {
                jagged[row][col] += value;
            }
            
        }
    }
    else if (info[0] == "subtract")
    {
        int row = int.Parse(info[1]);
        int col = int.Parse(info[2]);
        int value = int.Parse(info[3]);
        if (jagged.Length > row && row >= 0)
        {
            if (jagged[row].Length > col && col >= 0)
            {
                jagged[row][col] -= value;
            }

        }
    }

    command = Console.ReadLine().ToLower();
}

for (int row = 0; row < jagged.Length; row++)
{
    for (int col = 0; col < jagged[row].Length; col++)
    {
        Console.Write($"{jagged[row][col]} ");
    }
    Console.WriteLine();
}