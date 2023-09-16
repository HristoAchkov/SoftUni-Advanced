HashSet<string> VIPset = new HashSet<string>();
HashSet<string> regular = new HashSet<string>();

string command = Console.ReadLine();
bool isCommandParty = false;

while (command != "END")
{
    if (command.Length == 8)
    {
        if (char.IsDigit(command[0]))
        {
            VIPset.Add(command);
        }
        else
        {
            regular.Add(command);
        }
    }

    if (command == "PARTY")
	{
		isCommandParty = true;
	}

	if (isCommandParty)
	{
        if (char.IsDigit(command[0]))
        {
            if (VIPset.Contains(command))
            {
                VIPset.Remove(command);
            }
        }
        else
        {
			if (regular.Contains(command))
			{
                regular.Remove(command);
            }
        }
    }
	command = Console.ReadLine();
}
int count = VIPset.Count + regular.Count;
Console.WriteLine(count);
foreach (var item in VIPset)
{
	Console.WriteLine(item);
}
foreach (var item in regular)
{
	Console.WriteLine(item);
}