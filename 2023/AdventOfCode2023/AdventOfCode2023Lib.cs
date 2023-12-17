using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2023;

/// <summary>
/// https://adventofcode.com/2023
/// </summary>
public class AdventOfCode2023Lib
{
    private static string[] SplitLines(string lines)
    {
        char[] delimiters = new char[] { '\r', '\n' };
        return lines.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    }

    #region Day01

    public static long Day01_1(string input)
    {
        var lines = SplitLines(input);
        long sum = 0;
        foreach (var line in lines)
        {
            var digits = line
                .Select(c => c - 48)
                .Where(c => c >= 0 && c <= 9);
            sum += digits.First() * 10 + digits.Last();
        }

        return sum;
    }

    private static Dictionary<string, long> NumberWords = new Dictionary<string, long>()
    {
        {"zero", 0 },
        {"one", 1 },
        {"two", 2 },
        {"three", 3 },
        {"four", 4 },
        {"five", 5 },
        {"six", 6 },
        {"seven", 7 },
        {"eight", 8 },
        {"nine", 9 }
    };

    public static long Day01_2(string input)
    {
        var lines = SplitLines(input);
        long sum = 0;
        foreach (var line in lines)
        {
            var tempLine = line;
            var list = new List<long>();
            while(!string.IsNullOrEmpty(tempLine))
            {
                var removeChars = 1;
                if (tempLine[0] >= 48 && tempLine[0] <= 58)
                {
                    list.Add(tempLine[0] - 48);
                }
                else
                {
                    var numberWordMatches = NumberWords.Where(nw => tempLine.StartsWith(nw.Key));
                    if (numberWordMatches.Any())
                    {
                        var (word, number) = numberWordMatches.First();
                        list.Add(number);
                        removeChars = word.Length;
                    }
                }

                tempLine = tempLine.Remove(0, removeChars);
            }

            sum += list.First() * 10 + list.Last();
        }

        return sum;
    }

    #endregion

    #region Day02

    private static Dictionary<string,long> ColorValues = new Dictionary<string,long>()
    {
        {"red", 12 },
        {"green", 13 },
        {"blue", 14 }
    };

    /// <summary>
    /// Splits the input and returns an IEnumerable of tuples of type "(long Value, string Color)".
    /// </summary>
    /// <param name="setList"></param>
    /// <returns></returns>
    private static IEnumerable<(long Value, string Color)> Day02_ToSetList(string setList)
    {
        return setList
            .Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            .Select(s => (Value: long.Parse(s[0].Trim()), Color: s[1].Trim()));
    }

    private static long Day02_ToGameNumber(string input) => long.Parse(input.Split(' ').Skip(1).First());

    public static long Day02_1(string input) 
    {
        long sum = 0;
        var lines = SplitLines(input);
        foreach (var line in lines)
        {
            var game = line.Split(':', StringSplitOptions.RemoveEmptyEntries);
            var gameNumber = Day02_ToGameNumber(game[0]);
            var sets = Day02_ToSetList(game[1]);

            if (sets.Any(s => ColorValues[s.Color] < s.Value)) continue;
            sum += gameNumber;
        }

        return sum;
    }

    public static long Day02_2(string input)
    {
        long sum = 0;
        var lines = SplitLines(input);
        foreach (var line in lines)
        {
            var game = line.Split(':', StringSplitOptions.RemoveEmptyEntries);
            var gameNumber = Day02_ToGameNumber(game[0]);
            var sets = Day02_ToSetList(game[1]);

            var power = sets
                .GroupBy(s => s.Color)
                .Select(g => g.Max(x => x.Value))
                .Aggregate((a,b) => a * b);
            
            sum += power;
        }

        return sum;
    }

    #endregion

    #region Day03

    public static long Day03_1(string input)
    {
        long sum = 0;
        var lines = SplitLines(input);
        for (var row = 0; row < lines.Length; row++)
        {
            for (var column = 0;  column < lines[row].Length; column++)
            {
                var number = 0;
                var startColumn = column > 0 ? column - 1 : column;
                while (column < lines[row].Length && IsDigit(lines[row][column]))
                {
                    number = number * 10 + (lines[row][column] - 48);
                    column++;
                }
                if (number > 0)
                {
                    var endColumn = column >= lines[row].Length ? column - 1 : column;
                    var isSymbol = IsSymbol(lines[row][startColumn]) || IsSymbol(lines[row][endColumn]);
                    if (!isSymbol && row > 0) isSymbol = ContainsSymbol(lines[row - 1], startColumn, endColumn);
                    if (!isSymbol && row + 1 < lines.Length) isSymbol = ContainsSymbol(lines[row + 1], startColumn, endColumn);
                    if (isSymbol) sum += number;
                }
            }
        }

        return sum;
    }

    private static bool ContainsSymbol(string text, int start, int end) => text.Substring(start, (end - start) + 1).Any(IsSymbol);
    private static bool IsSymbol(char chr) => !IsDigit(chr) && chr != '.';
    private static bool IsDigit(char chr) => (chr >= '0' && chr <= '9');

    public static long Day03_2(string input)
    {
        long sum = 0;
        var lines = SplitLines(input);
        for (var row = 0; row < lines.Length; row++)
        {
            var line = lines[row];
            var offset = 0;
            var idx = 0;
            while ((idx = line.IndexOf('*', offset)) > 0)
            {
                var numbers = new List<long>();
                numbers.AddRange(ExtractNumbers(line, idx));
                if (row > 0) numbers.AddRange(ExtractNumbers(lines[row - 1], idx));
                if (row + 1 < lines.Length) numbers.AddRange(ExtractNumbers(lines[row + 1], idx));
                
                if (numbers.Count > 1) sum += numbers.Aggregate((a, b) => a * b);
                offset = idx + 1;
                if (offset >= line.Length) break;
            }
        }

        return sum;
    }

    private static IEnumerable<long> ExtractNumbers(string line, int idx)
    {
        var numbers = new List<long>();
        if (IsDigit(line[idx]))
        {
            numbers.Add(ExtractNumberLeftRight(line, idx));
        }
        else
        {
            if (idx > 0 && IsDigit(line[idx - 1])) numbers.Add(ExtractNumberLeft(line, idx - 1));
            if (idx + 1 < line.Length && IsDigit(line[idx + 1])) numbers.Add(ExtractNumberRight(line, idx + 1));
        }

        return numbers;
    }

    private static long ExtractNumberLeft(string line, int end)
    {
        var start = end;
        while (start - 1 >= 0 && IsDigit(line[start - 1])) start--;
        return PartToNumber(line, start, end);
    }

    private static long ExtractNumberRight(string line, int start)
    {
        var end = start;
        while (end + 1 < line.Length && IsDigit(line[end + 1])) end++;
        return PartToNumber(line, start, end);
    }

    private static long ExtractNumberLeftRight(string line, int idx)
    {
        var start = idx;
        var end = idx;
        while (start - 1 >= 0 && IsDigit(line[start - 1])) start--;
        while (end + 1 < line.Length && IsDigit(line[end + 1])) end++;
        return PartToNumber(line, start, end);
    }

    private static long PartToNumber(string text, int start, int end) => long.Parse(text.Substring(start, end - start + 1));

    #endregion

    #region Day04

    public static long Day04_1(string input)
    {
        long sum = 0;
        var lines = SplitLines(input);
        foreach (var line in lines)
        {
            var numbers = line.Split(':')[1].Split('|');
            var winningNumbers = ToNumberList(numbers[1])
                .Intersect(ToNumberList(numbers[0]))
                .ToList();
            if (winningNumbers.Count > 0) sum += 1 << (winningNumbers.Count - 1);
        }

        return sum;
    }

    private static List<long> ToNumberList(string input) 
        => input
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(s => long.Parse(s.Trim()))
        .ToList();

    public static long Day04_2(string input)
    {
        var lines = SplitLines(input);
        var cardCounter = Enumerable.Repeat(1, lines.Length).ToArray();
        for (var idx = 0; idx < lines.Length; idx++)
        {
            var numbers = lines[idx].Split(':')[1].Split('|');
            var winningNumbers = ToNumberList(numbers[1])
                .Intersect(ToNumberList(numbers[0]))
                .Count();
            // for each card with current card number...
            for (var i = 0; i < cardCounter[idx]; i++)
            {
                // ...add one won card to the following cards
                for (var y = 1; (idx + y) < cardCounter.Length && y <= winningNumbers; y++)
                {
                    cardCounter[idx + y] += 1;
                }
            }

        }

        return cardCounter.Aggregate((a,b) => a + b);
    }

    #endregion

    #region Day05

    private class MapEntry
    {
        public string SrcName;
        public long SrcStart;
        public string DstName;
        public long DstStart;
        public long Length;
    }

    private static IEnumerable<MapEntry> ExtractMappings(string[] lines, int lineIdx)
    {
        while (lineIdx < lines.Length)
        {
            var names = lines[lineIdx].Split(' ')[0].Split('-');
            var srcName = names[0];
            var dstName = names[2];
            lineIdx++;
            while (lineIdx < lines.Length && !string.IsNullOrEmpty(lines[lineIdx]))
            {
                var values = lines[lineIdx]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => long.Parse(x.Trim()))
                    .ToArray();

                yield return new MapEntry
                { 
                    SrcName = srcName, 
                    DstName = dstName, 
                    DstStart = values[0], 
                    SrcStart = values[1], 
                    Length = values[2]
                };

                lineIdx++;
            }
            lineIdx++;
        }
    }

    private static long MapSrcToDst(IEnumerable<MapEntry> mappings, string srcName, string dstName, long srcValue)
    {
        var result = mappings
            .Where(m => m.SrcName == srcName 
                    && m.DstName == dstName 
                    && srcValue >= m.SrcStart
                    && srcValue < m.SrcStart + m.Length)
            .Select(m => m.DstStart + (srcValue - m.SrcStart));
        return result.Any() ? result.First() : srcValue;
    }

    private static readonly string[] MappingNames = { "seed", "soil", "fertilizer", "water", "light", "temperature", "humidity", "location" };

    private static long MapSeedToLocation(IEnumerable<MapEntry> mappings, long seed)
    {
        var value = seed;
        for (var idx = 0; idx < MappingNames.Length - 1; idx++)
        {
            value = MapSrcToDst(mappings, MappingNames[idx], MappingNames[idx + 1], value);
        }
        return value;
    }

    public static long Day05_1(string input)
    {
        long result = 0;
        var lines = Regex.Split(input, "\r\n|\r|\n");
        var lineIdx = 0;
        var seeds = lines[lineIdx]
            .Split(':')[1]
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => long.Parse(x.Trim()))
            .ToArray();
        lineIdx += 2;
        var maps = ExtractMappings(lines, lineIdx).ToList();

        result = seeds.Select(s => MapSeedToLocation(maps, s)).Min();

        return result;
    }

    private static long MinDstForSrc(IEnumerable<MapEntry> mappings, string srcName, string dstName, 
        long srcValue, long range)
    {
        var result = mappings
            .Where(m => m.SrcName == srcName
                    && m.DstName == dstName
                    && srcValue >= m.SrcStart
                    && srcValue < m.SrcStart + m.Length)
            .Select(m => (Start: m.DstStart + (srcValue - m.SrcStart), Length: m.Length - (srcValue - m.SrcStart)));

        // TODO
        // The initial idea was to use the minimum in all mappings.
        // But we only search the minimum of the location (which is th last mapping).
        // Seems like we get one or two resulting ranges for each mapping, dpending if all seed values
        // fit into the defined mapping range (one resutl range) or not (two result ranges).


        if(result.Any())
        {
            var res = result.First();
            if (res.Length < range)
            {

            }
        }
        
        throw new NotImplementedException();
    }

    private static long MapSeedRangeToLocation(IEnumerable<MapEntry> mappings, long seed, long range)
    {
        var value = seed;
        for (var idx = 0; idx < MappingNames.Length - 1; idx++)
        {
            value = MinDstForSrc(mappings, MappingNames[idx], MappingNames[idx + 1], value, range);
        }
        return value;
    }

    public static long Day05_2(string input)
    {
        long result = 0;
        var lines = Regex.Split(input, "\r\n|\r|\n");
        var lineIdx = 0;
        var seeds = lines[lineIdx]
            .Split(':')[1]
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => long.Parse(x.Trim()))
            .ToArray();
        lineIdx += 2;
        var maps = ExtractMappings(lines, lineIdx).ToList();

        for (var idx = 0; idx < seeds.Length; idx += 2)
        {
            var res = MapSeedRangeToLocation(maps, seeds[idx], seeds[idx + 1]);
            if (res < result) result = res;
        }

        return result;
    }

    #endregion
}


