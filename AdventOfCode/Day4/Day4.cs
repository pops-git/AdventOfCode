namespace AdventOfCode.Day4;

public static class Day4
{
    public static void A1()
    {
        var lines = File.ReadLines("/home/linus/RiderProjects/AdventOfCode/AdventOfCode/Day4/info.txt").ToList();

        var bingoNumbers = lines[0].Split(",").Select(x => Convert.ToInt32(x)).ToList();

        lines.RemoveAt(0);

        var newLines = lines.Select(x => x.Split(" ", StringSplitOptions.RemoveEmptyEntries)).ToList();

        foreach (var line in newLines)
        {
            foreach (var myVar in line)
            {
                Console.WriteLine(myVar);
            }
        }
    }
}