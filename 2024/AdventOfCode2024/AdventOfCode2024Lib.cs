using System.Text.RegularExpressions;

namespace AdventOfCode2024;

/// <summary>
/// https://adventofcode.com/2024
/// </summary>
public static class AdventOfCode2024Lib
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
                valid = sign == prevSign && absDiff is > 0 and <= 3;
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
        => sign == prevSign && absDiff is > 0 and <= 3;

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
        var matches = Regex.Matches(input, @"mul\(\d{1,3},\d{1,3}\)");
        var sum = 0;

        foreach (var match in matches)
        {
            var numbers = Regex.Matches(match.ToString()!,@"\d{1,3}").Select(x => int.Parse(x.ToString())).ToArray();
            sum += numbers[0] * numbers[1];
        }

        return sum;
    }
    
    public static long Day03_2(string input)
    {
        var matches = Regex.Matches(input, @"mul\(\d{1,3},\d{1,3}\)|don't\(\)|do\(\)");
        var sum = 0;
        var enabled = true;

        foreach (var match in matches)
        {
            var cmd = match.ToString()!;
            if (cmd == "don't()")
            {
                enabled = false;
                continue;
            }

            if (cmd == "do()")
            {
                enabled = true;
                continue;
            }

            if (enabled)
            {
                var numbers = Regex.Matches(match.ToString()!,@"\d{1,3}").Select(x => int.Parse(x.ToString())).ToArray();
                sum += numbers[0] * numbers[1];
            }
        }

        return sum;
    }
    
    #endregion
    
    #region Day04
    
    public static long Day04_1(string input)
    {
        var lines = SplitLines(input);
        var width = lines[0].Length;
        var height = lines.Length;
        var sum = 0;
        var existMap = new int[height,width];

        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                if (lines[y][x] == 'X')
                {
                    (int,int)[] horizRight = [(y, SaveCalc(x, + 1, width)), 
                                              (y, SaveCalc(x, + 2, width)), 
                                              (y, SaveCalc(x, + 3, width)),(y,x)];
                    sum += CheckXmas(lines, existMap, horizRight);
                    (int,int)[] horizLeft = [(y, SaveCalc(x, - 1, width)), 
                                             (y, SaveCalc(x, - 2, width)), 
                                             (y, SaveCalc(x, - 3, width)),(y,x)];
                    sum += CheckXmas(lines, existMap, horizLeft);
                    
                    (int,int)[] verticalDown = [(SaveCalc(y, + 1, height), x), 
                                                (SaveCalc(y, + 2, height), x), 
                                                (SaveCalc(y, + 3, height), x),(y,x)];
                    sum += CheckXmas(lines, existMap, verticalDown);
                    (int,int)[] verticalUp = [(SaveCalc(y, - 1, height), x), 
                                              (SaveCalc(y, - 2, height), x), 
                                              (SaveCalc(y, - 3, height), x),(y,x)];
                    sum += CheckXmas(lines, existMap, verticalUp);
                    
                    (int,int)[] diagDownRight = [(SaveCalc(y, + 1, height), SaveCalc(x, + 1, width)), 
                                                 (SaveCalc(y, + 2, height), SaveCalc(x, + 2, width)), 
                                                 (SaveCalc(y, + 3, height), SaveCalc(x, + 3, width)),(y,x)];
                    sum += CheckXmas(lines, existMap, diagDownRight);
                    (int,int)[] diagDownLeft = [(SaveCalc(y, + 1, height), SaveCalc(x, - 1, width)), 
                                                (SaveCalc(y, + 2, height), SaveCalc(x, - 2, width)), 
                                                (SaveCalc(y, + 3, height), SaveCalc(x, - 3, width)),(y,x)];
                    sum += CheckXmas(lines, existMap, diagDownLeft);

                    (int,int)[] diagUpRight = [(SaveCalc(y, - 1, height), SaveCalc(x, + 1, width)), 
                                               (SaveCalc(y, - 2, height), SaveCalc(x, + 2, width)), 
                                               (SaveCalc(y, - 3, height), SaveCalc(x, + 3, width)),(y,x)];
                    sum += CheckXmas(lines, existMap, diagUpRight);
                    (int,int)[] diagUpLeft = [(SaveCalc(y, - 1, height), SaveCalc(x, - 1, width)), 
                                              (SaveCalc(y, - 2, height), SaveCalc(x, - 2, width)), 
                                              (SaveCalc(y, - 3, height), SaveCalc(x, - 3, width)),(y,x)];
                    sum += CheckXmas(lines, existMap, diagUpLeft);
                }
            }
        }

        PrintResultMap(existMap, lines, width, height);

        return sum;
    }
    
    private static int CheckXmas(string[] lines, int[,] existMap, (int y, int x)[] coords)
    {
        if (coords.Any(c => c.x == -1 || c.y == -1)) return 0;
        
        var result =   lines[coords[0].y][coords[0].x] == 'M' 
                       && lines[coords[1].y][coords[1].x] == 'A'
                       && lines[coords[2].y][coords[2].x] == 'S'
            ? 1 : 0;
        existMap[coords[0].y, coords[0].x] += result;
        existMap[coords[1].y, coords[1].x] += result;
        existMap[coords[2].y, coords[2].x] += result;
        existMap[coords[3].y, coords[3].x] += result;
        return result;
    }

    public static long Day04_2(string input)
    {
        var lines = SplitLines(input);
        var width = lines[0].Length;
        var height = lines.Length;
        var sum = 0;
        var existMap = new int[height,width];

        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                if (lines[y][x] == 'A')
                {
                    (int,int)[] horizRight = 
                        [(SaveCalc(y, + 1, height), SaveCalc(x, - 1, width)), 
                         (SaveCalc(y, - 1, height), SaveCalc(x, + 1, width)),
                         (SaveCalc(y, - 1, height), SaveCalc(x, - 1, width)), 
                         (SaveCalc(y, + 1, height), SaveCalc(x, + 1, width)),
                         (y,x)];
                    sum += CheckX_Mas(lines, existMap, horizRight);
                }
            }
        }

        PrintResultMap(existMap, lines, width, height);

        return sum;
    }

    private static void PrintResultMap(int[,] existMap, string[] lines, int width, int height)
    {
        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                Console.Write(existMap[y, x] > 0 ? lines[y][x] : '.');
            }
            Console.WriteLine();
        }
    }

    private static int CheckX_Mas(string[] lines, int[,] existMap, (int y, int x)[] coords)
    {
        if (coords.Any(c => c.x == -1 || c.y == -1)) return 0;
        
        var result =   (lines[coords[0].y][coords[0].x] == 'M' && lines[coords[1].y][coords[1].x] == 'S'
                       ||lines[coords[0].y][coords[0].x] == 'S' && lines[coords[1].y][coords[1].x] == 'M')
                       && (lines[coords[2].y][coords[2].x] == 'M' && lines[coords[3].y][coords[3].x] == 'S'
                       || lines[coords[2].y][coords[2].x] == 'S' && lines[coords[3].y][coords[3].x] == 'M')
            ? 1 : 0;
        existMap[coords[0].y, coords[0].x] += result;
        existMap[coords[1].y, coords[1].x] += result;
        existMap[coords[2].y, coords[2].x] += result;
        existMap[coords[3].y, coords[3].x] += result;
        existMap[coords[4].y, coords[4].x] += result;
        return result;
    }
    
    private static int SaveCalc(int value, int add, int max)
    {
        var result = value + add;
        if (result < 0 || result >= max) return -1;
        return result;
    }
    
    #endregion
    
    #region Day05

    public static int Day05_1(string input)
    {
        var lines = SplitLines(input);
        var sum = 0;
        
        var rules = lines.Where(l => l.Contains('|'))
            .Select(l => l.Split('|').Select(int.Parse).ToArray())
            .Select(x => (first:x[0],second:x[1])).ToList();
        var updates = lines.Where(l => l.Contains(','))
            .Select(l => l.Split(',').Select(int.Parse).ToArray()).ToList();

        foreach (var update in updates)
        {
            var matchingRules = rules.Where(x => update.Contains(x.first) && update.Contains(x.second)).ToList();
            var valid = true;
            for(var idx = 0; idx < update.Length && valid; idx++)
            {
                var page = update[idx];
                if (idx < update.Length - 1)
                {
                    var followingPages = update.Skip(idx + 1);
                    foreach (var followPage in followingPages)
                    {
                        valid = matchingRules.Any(x => x.first == page && x.second == followPage);
                        if (!valid) break;
                    }
                    if (!valid) break;
                }

                if (idx > 0)
                {
                    var precedingPages = update.Take(idx - 1);
                    foreach (var precedingPage in precedingPages)
                    {
                        valid = matchingRules.Any(x => x.first == precedingPage && x.second == page);
                        if (!valid) break;
                    }
                    if (!valid) break;
                }
            }

            if (valid)
            {
                var middleIdx = update.Length / 2;
                var value = update[middleIdx];
                sum += value;
                //Console.WriteLine($"{(string.Join(",", update.Select(x=>x.ToString())))} -> {value}");
            }
        }

        return sum;
    }
    
    public static int Day05_2(string input)
    {
        var lines = SplitLines(input);
        var sum = 0;
        
        var rules = lines.Where(l => l.Contains('|'))
            .Select(l => l.Split('|').Select(int.Parse).ToArray())
            .Select(x => (first:x[0],second:x[1])).ToList();
        var updates = lines.Where(l => l.Contains(','))
            .Select(l => l.Split(',').Select(int.Parse).ToArray()).ToList();

        foreach (var update in updates)
        {
            var matchingRules = rules.Where(x => update.Contains(x.first) && update.Contains(x.second)).ToList();
            var valid = true;
            for(var idx = 0; idx < update.Length && valid; idx++)
            {
                var page = update[idx];
                if (idx < update.Length - 1)
                {
                    var followingPages = update.Skip(idx + 1);
                    foreach (var followPage in followingPages)
                    {
                        valid = matchingRules.Any(x => x.first == page && x.second == followPage);
                        if (!valid) break;
                    }
                    if (!valid) break;
                }

                if (idx > 0)
                {
                    var precedingPages = update.Take(idx - 1);
                    foreach (var precedingPage in precedingPages)
                    {
                        valid = matchingRules.Any(x => x.first == precedingPage && x.second == page);
                        if (!valid) break;
                    }
                    if (!valid) break;
                }
            }

            if (!valid)
            {
                var result = new List<int>();
                var orderedRules = matchingRules.GroupBy(x => x.first).OrderByDescending(x => x.Count()).ToList();
                result.AddRange(orderedRules.Select(x => x.First().first));
                result.Add(matchingRules.GroupBy(x => x.second).OrderByDescending(x => x.Count()).Select(x => x.First().second).First());
                
                var middleIdx = result.Count / 2;
                var value = result[middleIdx];
                sum += value;
                //Console.WriteLine($"{(string.Join(",", result.Select(x=>x.ToString())))} -> {value}");
            }
        }

        return sum;
    }
    
    #endregion
    
    #region Day06

    public static int Day06_1(string input)
    {
        var lines = SplitLines(input);
        var width = lines.First().Length;
        var height = lines.Length;
        var x = 0;
        var y = 0;
        var steps = 1;
        // find beginning position
        for (var idx = 0; idx < lines.Length; idx++)
        {
            x = lines[idx].IndexOf('^');
            if (x != -1)
            {
                y = idx;
                break;
            }
        }

        // four possible moves to iterate
        var moves = new[]
        {
            (x: 0, y: -1), 
            (x: 1, y: 0),
            (x: 0, y: 1),
            (x: -1, y: 0)
        };
        var moveIdx = 0;

        // log where we have been as we need the number of distinct visited positions
        var pathLog = new char[width, height];
        // we are already visiting one position
        pathLog[x, y] = 'X';

        var isOnMap = true;
        while (isOnMap)
        {
            var nextX = x + moves[moveIdx].x;
            var nextY = y + moves[moveIdx].y;
            isOnMap = IsOnMap(nextX, nextY, width, height);
            if (isOnMap)
            {
                if (lines[nextY][nextX] == '#')
                {
                    pathLog[nextX, nextY] = '#';
                    moveIdx++;
                    if (moveIdx == moves.Length)
                    {
                        moveIdx = 0;
                    }
                }
                else
                {
                    x = nextX;
                    y = nextY;
                    if (pathLog[x, y] == 0)
                    {
                        steps++;
                        pathLog[x, y] = 'X';
                    }
                }
            }
        }

        for (y = 0; y < height; y++)
        {
            for (x = 0; x < width; x++)
            {
                Console.Write(pathLog[x, y] > 0 ? pathLog[x, y] : '.');
            }
            Console.WriteLine();
        }

        return steps;
    }

    private static bool IsOnMap(int x, int y, int width, int height)
        => x >= 0 && x < width && y >= 0 && y < height;
    
    // four possible moves to iterate
    private static readonly (int x,int y)[] Day06Directions =
    [
        (0,0),
        (0, -1), 
        (1, 0),
        (0, 1),
        (-1, 0)
    ];
    
    public static int Day06_2(string input)
    {
        var lines = SplitLines(input);
        var width = lines.First().Length;
        var height = lines.Length;
        var x = 0;
        var y = 0;
        var obstacles = 0;
        // find beginning position
        for (var idx = 0; idx < lines.Length; idx++)
        {
            x = lines[idx].IndexOf('^');
            if (x != -1)
            {
                y = idx;
                break;
            }
        }

        var direction = 1;

        // log where we have been as we need the number of distinct visited positions
        var pathLog = new char[width, height];
        var directionLog = new int[width, height];
        // we are already visiting one position
        pathLog[x, y] = 'x';
        directionLog[x, y] = direction;

        var steps = 0;
        var isOnMap = true;
        while (isOnMap)
        {
            var nextX = x + Day06Directions[direction].x;
            var nextY = y + Day06Directions[direction].y;
            isOnMap = IsOnMap(nextX, nextY, width, height);
            if (isOnMap)
            {
                // Console.WriteLine($"{x}, {y}, {direction}");
                if (lines[nextY][nextX] == '#')
                {
                    direction = NextDirection(direction);
                    directionLog[x, y] = direction;
                    pathLog[nextX, nextY] = '#';
                }
                else
                {
                    // https://www.reddit.com/r/adventofcode/comments/1h7y9ws/2024_day_6_part_2_finally_found_the_issue_in_my/
                    // check if we get to a loop if we turn here at the current position (x,y)
                    var alteredDirection = NextDirection(direction);
                    var alteredX = x;
                    var alteredY = y;
                    var alteredIsOnMap = true;
                    var alteredDirectionLog = new int[width, height];
                    alteredDirectionLog[alteredX,alteredY] = alteredDirection;
                    while (alteredIsOnMap)
                    {
                        var alteredNextX = alteredX + Day06Directions[alteredDirection].x;
                        var alteredNextY = alteredY + Day06Directions[alteredDirection].y;
                        alteredIsOnMap = IsOnMap(alteredNextX, alteredNextY, width, height); 
                        if (alteredIsOnMap)
                        {
                            if (alteredNextX == x && alteredNextY == y && alteredDirection == direction
                                || alteredDirectionLog[alteredNextX,alteredNextY] == NextDirection(alteredDirection)
                                )
                            {
                                obstacles++;
                                pathLog[nextX, nextY] = '0';
                                break;
                            }

                            if (lines[alteredNextY][alteredNextX] == '#')
                            {
                                alteredDirection = NextDirection(alteredDirection);
                            }
                            else
                            {
                                steps++;
                                alteredX = alteredNextX;
                                alteredY = alteredNextY;
                                alteredDirectionLog[alteredX,alteredY] = alteredDirection;
                            }
                        }
                    }

                    steps++;
                    x = nextX;
                    y = nextY;
                    if (pathLog[x, y] == 0)
                    {
                        pathLog[x, y] = 'x';
                    }

                    directionLog[x, y] = direction;
                }
            }
        }

        for (y = 0; y < height; y++)
        {
            for (x = 0; x < width; x++)
            {
                Console.Write(pathLog[x, y] > 0 ? pathLog[x, y] : '.');
            }
            Console.WriteLine();
        }

        return obstacles;
    }

    private static int NextDirection(int direction)
    {
        direction++;
        if (direction == Day06Directions.Length)
        {
            direction = 1;
        }

        return direction;
    }

    #endregion
}