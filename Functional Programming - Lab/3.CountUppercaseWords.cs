string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Predicate<string> isUpper = x => char.IsUpper(x[0]);

string[] upperCase =
    text.Where(x => isUpper(x))
    .ToArray();

foreach (var item in upperCase)
{
    Console.WriteLine(item);
}