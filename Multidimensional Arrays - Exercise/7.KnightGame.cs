int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

if (n < 3)
{
	Console.WriteLine(0);
	return;
}

for (int row = 0; row < n; row++)
{
    string input = Console.ReadLine();

    for (int col = 0; col < n; col++)
	{
		matrix[row, col] = input[col];
	}
}

int knightsCount = 0;
bool isCellValid = true;
while (true)
{
	int countMostAttacking = 0;
	int maxRow = 0;
	int maxCol = 0;

    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
        {
			if (matrix[row, col] == 'K')
			{
                int attackedKnights = CountAttackedKnights(row, col, n, matrix);

				if (countMostAttacking < attackedKnights)
				{
					countMostAttacking = attackedKnights;
					maxRow = row;
					maxCol = col;
				}
			}
        }
    }

	if (countMostAttacking == 0)
	{
		break;
	}
	else
	{
		matrix[maxRow, maxCol] = '0';
		knightsCount++;
	}
}

Console.WriteLine(knightsCount);


static int CountAttackedKnights(int row, int col, int n, char[,] matrix)
{
	int attackedKnights = 0;

	if (IsCellValid(row - 1, col - 2, n))
	{
		if (matrix[row - 1,col - 2] == 'K')
		{
			attackedKnights++;
		}
	}

    if (IsCellValid(row + 1, col - 2, n))
    {
        if (matrix[row + 1, col - 2] == 'K')
        {
            attackedKnights++;
        }
    }

    if (IsCellValid(row - 1, col + 2, n))
    {
        if (matrix[row - 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }

    if (IsCellValid(row + 1, col + 2, n))
    {
        if (matrix[row + 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }

    if (IsCellValid(row - 2, col - 1, n))
    {
        if (matrix[row - 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }

    if (IsCellValid(row - 2, col + 1, n))
    {
        if (matrix[row - 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }

    if (IsCellValid(row + 2, col - 1, n))
    {
        if (matrix[row + 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }

    if (IsCellValid(row + 2, col + 1, n))
    {
        if (matrix[row + 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }

    return attackedKnights;
}

static bool IsCellValid(int row, int col, int n)
{
	return
		row >= 0 
		&& row < n 
		&& col >= 0 
		&& col < n;
}

