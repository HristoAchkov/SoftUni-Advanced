HashSet<string> set = new HashSet<string>();

string command = Console.ReadLine();

while (command != "END")
{
    string[] info = command.Split(", ");

    string direction = info[0];
    string number = info[1];

    if (direction == "IN")
    {
        set.Add(number);
    }
    else
    {
        set.Remove(number);
    }
    command = Console.ReadLine();
}

if (set.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (var item in set)
    {
        Console.WriteLine(item);
    }
}


