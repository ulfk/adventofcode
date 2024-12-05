namespace AdventOfCode2024;

public class AdventOfCode2024Lib
{
    private static string[] SplitLines(string lines)
    {
        char[] delimiters = ['\r', '\n'];
        return lines.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    }
    
    #region Day01

    public static long Day01_1(List<int> first, List<int> second)
    {
        long sum = 0;
        first.Sort();
        second.Sort();

        for (int i = 0; i < first.Count; i++)
        {
            sum += Math.Abs(first[i] - second[i]);
        }

        return sum;
    }
    
    public static long Day01_2(List<int> first, List<int> second)
    {
        long sum = 0;
        var secondGrouped = second.GroupBy(x => x).ToList();

        foreach (var value in first)
        {
            var count = secondGrouped.Where(x => x.Key == value).Select(x => x.Count()).FirstOrDefault();
            sum += value * count;
        }

        return sum;
    }
    
    #endregion
    
    #region Day02

    public static long Day02_1(string input)
    {
        var lines = SplitLines(input);
        long sum = 0;

        const int undefinedSign = int.MaxValue;
        foreach (var line in lines)
        {
            var values = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var prevSign = undefinedSign;
            var valid = true;
            for (var i = 1; i < values.Length && valid; i++)
            {
                var diff = values[i - 1] - values[i];
                var sign = Math.Sign(diff);
                var absDiff = Math.Abs(diff);
                if (prevSign == undefinedSign) prevSign = sign;
                valid = sign == prevSign && absDiff > 0 && absDiff <= 3;
            }

            if (valid) sum++;
        }

        return sum;
    }
    
    public static long Day02_2(string input)
    {
        var lines = SplitLines(input);
        long sum = 0;

        foreach (var line in lines)
        {
            var values = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (IsLineValid(values)) sum++;
        }

        return sum;
    }

    private static (int sign, int absDiff) GetSignAndAbsDiff(int[] values, int idx1, int idx2)
    {
        var diff = values[idx1] - values[idx2];
        return (Math.Sign(diff), Math.Abs(diff));
    }
    
    private static bool IsValidDiff(int sign, int prevSign, int absDiff) 
        => sign == prevSign && absDiff > 0 && absDiff <= 3;

    private static bool IsLineValid(int[] values, bool skippedOne = false)
    {
        var prevSign = 0;
        var valid = true;
        for (var i = 1; i < values.Length && valid; i++)
        {
            var (sign, absDiff) = GetSignAndAbsDiff(values, i - 1, i);
            if (i == 1) prevSign = sign;
            valid = IsValidDiff(sign, prevSign, absDiff);
            if (!valid && !skippedOne)
            {
                for (var skipIdx = i; skipIdx >= 0 && !valid; skipIdx--)
                {
                    valid = IsLineValid(Skip(values, skipIdx), true);
                }

                break;
            }
        }

        return valid;
    }
    
    private static int[] Skip(int[] values, int idx)
    {
        var newValues = new int[values.Length - 1];
        var newIdx = 0;
        for (var i = 0; i < values.Length; i++)
        {
            if (i == idx) continue;
            newValues[newIdx] = values[i];
            newIdx++;
        }

        return newValues;
    }
    
    #endregion
    
    #region Day03

    public static long Day03_1(string input)
    {
        throw new NotImplementedException();
    }
    
    #endregion
}