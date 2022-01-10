namespace AdventOfCode.Day1;

public static class Day1
{
    public static void A1()
    {
        var lines = File.ReadLines("C:\\Users\\linus\\RiderProjects\\AdventOfCode\\AdventOfCode\\Day1\\info.txt");

        var counter = -1;
        var lastNumber = 0;
        
        foreach (var line in lines)
        {
            if (Int32.Parse(line) > lastNumber)
            {
                counter++;
            }
            lastNumber = Int32.Parse(line);
        }

        Console.WriteLine(counter);
    }

    public static void A2()
    {
        var lines = File.ReadLines("C:\\Users\\linus\\RiderProjects\\AdventOfCode\\AdventOfCode\\Day1\\info.txt");
        var ints = lines.Select(int.Parse).ToArray();
        
        var counter = 0;
        var lastChain = new int[3] { ints[0], ints[1], ints[2] };

        for (int i = 1; i < ints.Length - 2; i++)
        {
            var currentChain = new int[3] { ints[i], ints[i + 1], ints[i + 2] };
            if (currentChain.Sum() > lastChain.Sum())
            {
                counter++;
            }

            lastChain = currentChain;
        }

        Console.WriteLine(counter);
    }
}