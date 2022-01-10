namespace AdventOfCode.Day4;

public static class Day4
{
    public static void A1()
    {
        var lines = File.ReadLines("C:\\Users\\linus\\RiderProjects\\AdventOfCode\\AdventOfCode\\Day4\\info.txt").ToList();

        var bingoNumbers = lines[0].Split(",").Select(x => Convert.ToInt32(x)).ToList();

        lines.RemoveAt(0);

        var newLines = lines.Select(x => x.Split(" ", StringSplitOptions.RemoveEmptyEntries)).ToList();

        var intLines = lines.Select(x => Convert.ToInt32(x)).ToList();

        foreach (var line in intLines)
        {
            Console.WriteLine(line);
        }
    }
}