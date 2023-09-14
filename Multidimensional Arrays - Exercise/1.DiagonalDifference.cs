int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n,n];

for (int row = 0; row < n; row++)
{
	int[] info = Console.ReadLine().Split().Select(int.Parse)
		.ToArray();
	for (int col = 0; col < n; col++)
	{
		matrix[row, col] = info[col];
	}
}

int diagonal1 = 0;
int diagonal2 = 0;

for (int row = 0; row < n; row++)
{
	for (int col = 0; col < n; col++)
	{
		if (row == col)
		{
			diagonal1 += matrix[row,col];
		}
	}
}

for (int row = 0; row < n; row++)
{
	for (int col = n; col >= 0 ; col--)
	{
		if (col == n - 1 - row)
		{
            diagonal2 += matrix[row,col];
        }
	}
}
int sum = Math.Abs(diagonal1 - diagonal2);
Console.WriteLine(sum);