using AdventOfCode2022;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using System.IO;

namespace AdventOfCode2022Tests
{
    [TestClass]
    public class AdventOfCode2022LibTests
    {
        #region Day01

        [TestMethod]
        public void Day01_Example()
        {
            var input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";
            var result = AdventOfCode2022Lib.Day01_MaxCalories(input);
            Check.That(result).Equals(45000);
        }

        [TestMethod]
        public void Day01_Final()
        {
            var input = File.ReadAllText("Day01.txt");
            var result = AdventOfCode2022Lib.Day01_MaxCalories(input);
            Check.That(result).Equals(200945);
        }

        #endregion

        #region Day02

        [TestMethod]
        public void Day02_Example()
        {
            var input = @"A Y
B X
C Z";
            var result = AdventOfCode2022Lib.Day02_CalcScore(input);
            Check.That(result).Equals(12);
        }

        [TestMethod]
        public void Day02_Final()
        {
            var input = File.ReadAllText("Day02.txt");
            var result = AdventOfCode2022Lib.Day02_CalcScore(input);
            Check.That(result).Equals(14859);
        }

        #endregion

        #region Day03

        [TestMethod]
        public void Day03_Example()
        {
            var input = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";
            var result = AdventOfCode2022Lib.Day03_GetPrioritySum(input);
            Check.That(result).Equals(157);
        }

        [TestMethod]
        public void Day03_Final()
        {
            var input = File.ReadAllText("Day03.txt");
            var result = AdventOfCode2022Lib.Day03_GetPrioritySum(input);
            Check.That(result).Equals(8252);
        }

        [TestMethod]
        public void Day03_Example2()
        {
            var input = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";
            var result = AdventOfCode2022Lib.Day03_GetPrioritySum2(input);
            Check.That(result).Equals(70);
        }

        [TestMethod]
        public void Day03_Final2()
        {
            var input = File.ReadAllText("Day03.txt");
            var result = AdventOfCode2022Lib.Day03_GetPrioritySum2(input);
            Check.That(result).Equals(2828);
        }
        #endregion
    }
}


