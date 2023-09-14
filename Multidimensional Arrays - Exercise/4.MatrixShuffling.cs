using System.Globalization;

string[] input = Console.ReadLine().Split();

int rows = int.Parse(input[0]);
int cols = int.Parse(input[1]);

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
	string[] info = Console.ReadLine().Split();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = info[col];
	}
}

string command = Console.ReadLine().ToLower();

while (command != "end")
{
	string[] info = command.Split();
	if (info[0] != "swap" || info.Length > 5)
	{
		Console.WriteLine("Invalid input!");
	}
	else
	{
		int firstRow = int.Parse(info[1]);
        int firstCol = int.Parse(info[2]);
        int secondRow = int.Parse(info[3]);
        int secondCol = int.Parse(info[4]);

		if (firstRow > rows || firstRow < 0 || firstCol > cols || firstCol < 0
			||secondRow > rows || secondRow < 0 || secondCol > cols || secondCol < 0)
		{
			Console.WriteLine("Invalid input!");
		}
		else
		{
			var first = matrix[firstRow, firstCol];
			matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
			matrix[secondRow, secondCol] = first;
			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					Console.Write($"{matrix[row,col]} ");
				}
				Console.WriteLine();
			}
		}
    }

	command = Console.ReadLine().ToLower();
}