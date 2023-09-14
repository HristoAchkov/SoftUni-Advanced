int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

for (int i = 0; i < n; i++)
{
	string info = Console.ReadLine();
	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = info[j];
	}
}

char symbol = char.Parse(Console.ReadLine());
bool isCharThere = false;
for (int i = 0; i < matrix.Length; i++)
{
	for (int j = 0; j < matrix.Length; j++)
	{
		if (matrix[i,j] == symbol)
		{
			Console.WriteLine(matrix[i, j]);
			return;
		}
    }
}

Console.WriteLine($"{symbol} does not occur in the matrix");