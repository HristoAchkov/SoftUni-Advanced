long rows = long.Parse(Console.ReadLine());

long[][] jagged = new long[rows][];

jagged[0] = new long[1] {1};

for (long row = 1; row < jagged.Length; row++)
{
    jagged[row] = new long[row + 1];
	for (long col = 0; col < jagged[row].Length; col++)
	{
		if (jagged[row - 1].Length > col)
		{
            jagged[row][col] += jagged[row - 1][col];
        }
		if (col > 0)
		{
            jagged[row][col] += jagged[row - 1][col - 1];
        }
	}
}

for (long row = 0; row < jagged.Length; row++)
{
	for (long col = 0; col < jagged[row].Length; col++)
	{
		Console.Write($"{jagged[row][col]} ");
	}
	Console.WriteLine();
}