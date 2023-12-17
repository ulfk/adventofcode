using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace AdventOfCode2022
{
	// Implementations for tasks found here: https://adventofcode.com/2022
	// Solution from another dveloper: https://github.com/vjakovlev/AdventOfCode
    public static class AdventOfCode2022Lib
    {
        #region Day01

        private static void SortInValue_Old(int[] max, int current)
        {
            if (current > max[2])
            {
                max[0] = max[1];
                max[1] = max[2];
                max[2] = current;
            }
            else if (current > max[1])
            {
                max[0] = max[1];
                max[1] = current;
            }
            else if (current > max[0])
            {
                max[0] = current;
            }
        }

        private static void SortInValue(int[] max, int current)
        {
            for(var idx = max.Length - 1; idx >= 0; idx--)
            {
                if (current <= max[idx]) continue;

                for (var j = 0; j < idx; j++)
                {
                    max[j] = max[j + 1];
                }
                max[idx] = current;
                break;
            }
        }

        public static int Day01_MaxCalories(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var max = new int[3] {0,0,0};
            var current = 0;
            foreach (var line in lines)
            {
                if (line == "")
                {
                    SortInValue(max, current);
                    current = 0;
                }
                else
                {
                    current += int.Parse(line);
                }
            }
            if (current > 0) SortInValue(max, current);
            return max.Sum();
        }

        #endregion

        #region Day02

        private static int GetMove(char move)
        {
            var sub = 'X';
            if (move >= 'A' && move <= 'C') sub = 'A';
            return move - sub + 1;
        }

        private static int Play(int other, int own)
        {
            switch (other * 10 + own)
            {
                case 11:
                case 22:
                case 33:
                    return 3 + own;
                case 13:
                case 21:
                case 32:
                    return 0 + own;
                case 12:
                case 23:
                case 31:
                    return 6 + own;
            }

            throw new Exception($"something went wrong: other={other} own={own}");
        }

        static int[] winMove = new int[3] { 2, 3, 1 };
        static int[] loseMove = new int[3] { 3, 1, 2 };
        private static int Play2(int other, int result)
        {
            switch (result)
            {
                case 1: // lose
                    return 0 + loseMove[other - 1];
                case 2: // draw
                    return 3 + other;
                case 3: // win
                    return 6 + winMove[other - 1];
            }
            throw new Exception($"something went wrong: other={other} result={result}");
        }

        public static int Day02_CalcScore(string input)
        {
            int score = 0;
            var commands = input.Split(Environment.NewLine).Select(x => x.Split(' '));
            foreach (var command in commands)
            {
                var other = GetMove(command[0][0]);
                var own = GetMove(command[1][0]);
                score += Play2(other, own);
            }

            return score;
        }

        #endregion

        #region Day03

        private static int ToPriority(this char input)
        {
            if (input >= 'a' && input <= 'z')
            {
                return input - 'a' + 1;
            }
            else if (input >= 'A' && input <= 'Z')
            {
                return input - 'A' + 27;
            }
            
            throw new Exception($"wrong char: '{input}'");
        }

        public static int Day03_GetPrioritySum(string input)
        {
            int sum = 0;
            var lines = input.Split(Environment.NewLine);

            foreach(var line in lines)
            {
                var halfLen = line.Length / 2;
                var first = line.Substring(0, halfLen);
                var second = line.Substring(halfLen, halfLen);

                sum += first.Intersect(second).First().ToPriority();
                //foreach (var ch in first)
                //{
                //    if (second.Contains(ch))
                //    {
                //        sum += ch.ToPriority();
                //        break;
                //    }
                //}
            }

            return sum;
        }

        public static int Day03_GetPrioritySum2(string input)
        {
            int sum = 0;
            var lines = input.Split(Environment.NewLine);

            for(var idx = 0; idx < lines.Length; idx += 3)
            {
                var first = lines[idx];
                var second = lines[idx + 1];
                var third = lines[idx + 2];

                sum += first.Intersect(second).Intersect(third).First().ToPriority();
                //foreach (var ch in first)
                //{
                //    if (second.Contains(ch) && third.Contains(ch))
                //    {
                //        sum += ch.ToPriority();
                //        break;
                //    }
                //}
            }

            return sum;
        }

        #endregion
    }
}


