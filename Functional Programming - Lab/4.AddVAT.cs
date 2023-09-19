double[] prices = Console.ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .Select(x => x * 1.20)
    .ToArray();

foreach (var item in prices)
{
    Console.WriteLine($"{item:f2}");
}