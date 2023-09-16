int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

numbers = numbers.OrderByDescending(x => x).ToArray();

if (numbers.Length >= 3)
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write(numbers[i]);
        Console.Write(" ");
    }
}
else
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]);
        Console.Write(" ");
    }
}