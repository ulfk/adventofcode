using System.Text.RegularExpressions;

namespace AdventOfCode2025;

/// <summary>
/// https://adventofcode.com/2025
/// </summary>
public static class AdventOfCode2025Lib
{
    private static string[] SplitLines(string lines)
    {
        char[] delimiters = ['\r', '\n'];
        return lines.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    }
    
    #region Day01

    // https://adventofcode.com/2025/day/1
    
    private static long Day01ToMove(string value)
    {
        return long.Parse(value[1..]) * (value[0] == 'R' ? 1 : -1);
    }

    public static long Day01_1(string input)
    {
        var moves = SplitLines(input).Select(Day01ToMove).ToArray();
        long dial = 50;
        long zeroCounter = 0;
        foreach (var move in moves)
        {
            dial += move;
            while (dial < 0) dial += 100;
            while (dial >= 100) dial -= 100;
            if (dial == 0) zeroCounter++;
        }

        return zeroCounter;
    }

    
    public static long Day01_2(string input)
    {
        var moves = SplitLines(input).Select(Day01ToMove).ToArray();
        long dial = 50;
        long zeroCounter = 0;
        foreach (var move in moves)
        {
            if (move > 0)
            {
                var moveVal = move;
                while (dial + moveVal >= 100)
                {
                    moveVal -= 100;
                    zeroCounter++;
                }

                dial += moveVal;
            }
            else
            {
                var moveVal = move;
                var addValue = (dial == 0 ? 0 : 1);
                while (moveVal + dial < 0)
                {
                    moveVal += 100;
                    zeroCounter += addValue;
                    if (addValue == 0) addValue = 1;
                }
                
                dial += moveVal;
                zeroCounter += (dial == 0 ? 1 : 0);
            }
        }
        
        return zeroCounter;
    }
    
    #endregion

}