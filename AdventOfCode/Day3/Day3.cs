namespace AdventOfCode.Day3;

public static class Day3
{
    public static void A1()
    {
        var lines = File.ReadLines("C:\\Users\\linus\\RiderProjects\\AdventOfCode\\AdventOfCode\\Day3\\info.txt");

        var listOfCharArrs = lines.Select(l => l.ToCharArray()).ToList();

        var gamma = new int[12];
        var epsilon = new int[12];

        var zeros = new int[12];
        var ones = new int[12];
        
        //itererar igenom alla arrayer
        foreach (var charArr in listOfCharArrs)
        {
            //adderar 1 per vardera binär som finns på en given binär plats (0-11)
            for (int i = 0; i < charArr.Length; i++)
            {
                switch (charArr[i])
                {
                    case '0':
                        zeros[i]++;
                        break;
                    case '1':
                        ones[i]++;
                        break;
                }
            }
        }
        //skapar korrekt binärt tal på korrekt binär plats utefter givna regler för gamma och epsilon
        for (int i = 0; i < zeros.Length; i++)
        {
            if (zeros[i] > ones[i])
            {
                gamma[i] = 0;
                epsilon[i] = 1;
            }
            else
            {
                gamma[i] = 1;
                epsilon[i] = 0;
            }
        }

        var gammaString = String.Join("", gamma);
        var epsilonString = String.Join("", epsilon);

        Console.WriteLine(Convert.ToInt32(gammaString, 2) * Convert.ToInt32(epsilonString, 2));
    }

    public static void A2()
    {
        var lines = File.ReadLines("C:\\Users\\linus\\RiderProjects\\AdventOfCode\\AdventOfCode\\Day3\\info.txt");
        
        var listOfCharArrs = lines.Select(l => l.ToCharArray()).ToList();

        var oxygenBinaryArrs = listOfCharArrs;
        var co2BinaryArrs = listOfCharArrs;
        
        //itererar igenom de 12 binära platserna
        for (int i = 0; i < 12; i++)
        {
            //håller antalet 1 respektive 0 i en given binär plats
            var oxygenZeros = 0;
            var oxygenOnes = 0;
            var co2Zeros = 0;
            var co2Ones = 0;
            
            //själva räknaren för oxygen
            foreach (var charArr in oxygenBinaryArrs)
            {
                switch (charArr[i])
                {
                    case '0':
                        oxygenZeros++;
                        break;
                    case '1':
                        oxygenOnes++;
                        break;
                }
            }
            //räknaren för co2
            foreach (var charArr in co2BinaryArrs)
            {
                switch (charArr[i])
                {
                    case '0':
                        co2Zeros++;
                        break;
                    case '1':
                        co2Ones++;
                        break;
                }
            }
            //minskar listan med binära tal för oxygen
            if (oxygenBinaryArrs.Count() > 1)
            {
                if (oxygenZeros > oxygenOnes)
                {
                    oxygenBinaryArrs = oxygenBinaryArrs.Where(x => x[i] == '0').ToList();
                }
                else if (oxygenOnes >= oxygenZeros)
                {
                    oxygenBinaryArrs = oxygenBinaryArrs.Where(x => x[i] == '1').ToList();
                }
            }
            //minskar listan med binära tal för co2
            if (co2BinaryArrs.Count() > 1)
            {
                if (co2Zeros <= co2Ones)
                {
                    co2BinaryArrs = co2BinaryArrs.Where(x => x[i] == '0').ToList();
                }
                else if (co2Ones < co2Zeros)
                {
                    co2BinaryArrs = co2BinaryArrs.Where(x => x[i] == '1').ToList();
                }
            }
        }
        //skapar binära strängar av den sista arrayen i respektive oxygen/co2-lista
        var oxygenBinary = String.Join("", oxygenBinaryArrs[0]);
        var co2Binary = String.Join("", co2BinaryArrs[0]);
        Console.WriteLine(Convert.ToInt32(oxygenBinary, 2) * Convert.ToInt32(co2Binary, 2));
    }
}