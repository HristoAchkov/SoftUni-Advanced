﻿
int[] array = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToArray();

Console.Write(string.Join(", ", array));