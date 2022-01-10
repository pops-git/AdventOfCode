namespace AdventOfCode.Day2;

public static class Day2
{
    public static void A1()
    {
        var lines = File.ReadLines("C:\\Users\\linus\\RiderProjects\\AdventOfCode\\AdventOfCode\\Day2\\info.txt");

        var forward = 0;
        var depth = 0;
        
        foreach (var line in lines)
        {
            var word = line.Split();

            switch (word[0])
            {
                case "forward":
                    forward += int.Parse(word[1]);
                    break;
                
                case "down":
                    depth += int.Parse(word[1]);
                    break;
                
                case "up":
                    depth -= int.Parse(word[1]);
                    break;
            }
        }

        Console.WriteLine(forward * depth);
    }

    public static void A2()
    {
        var lines = File.ReadLines("C:\\Users\\linus\\RiderProjects\\AdventOfCode\\AdventOfCode\\Day2\\info.txt");

        var forward = 0;
        var depth = 0;
        var aim = 0;
        
        foreach (var line in lines)
        {
            var word = line.Split();

            switch (word[0])
            {
                case "forward":
                    forward += int.Parse(word[1]);
                    depth += aim * int.Parse(word[1]);
                    break;
                
                case "down":
                    aim += int.Parse(word[1]);
                    break;
                
                case "up":
                    aim -= int.Parse(word[1]);
                    break;
            }
        }

        Console.WriteLine(forward * depth);
    }
}