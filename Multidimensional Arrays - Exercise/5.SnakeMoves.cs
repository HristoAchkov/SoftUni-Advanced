int[] input = Console.ReadLine().Split().Select(int.Parse)
    .ToArray();

string snake = Console.ReadLine();

int rows = input[0];
int cols = input[1];

char[,] matrix = new char[rows, cols];

int currentWord = 0;

for (int row = 0; row < rows; row++)
{
	if (row % 2 == 0)
	{
        for (int col = 0; col < cols; col++)
        {
            if (currentWord == snake.Length)
            {
                currentWord = 0;
            }
            matrix[row, col] = snake[currentWord];

            currentWord++;
        }
    }

    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            if (currentWord == snake.Length)
            {
                currentWord = 0;
            }
            matrix[row, col] = snake[currentWord];

            currentWord++;
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row,col]);
    }
    Console.WriteLine();
}