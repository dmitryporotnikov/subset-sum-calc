using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace SUBSET_SUM_CALC
{
    public class SubsetSumSolver
    {
        public static List<string> Solve(string inputText, decimal targetSum)
        {
            // Prune non-numeric characters
            inputText = Regex.Replace(inputText, @"[^\d.,-]+", " ").Trim();

            var numbers = inputText.Split(' ')
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s =>
                {
                    decimal.TryParse(s.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result);
                    return result;
                })
                .ToList();

            var solutions = FindSubsets(numbers, targetSum);

            if (solutions.Count == 0)
            {
                return new List<string> { "No combinations found." };
            }

            return solutions.Select(solution =>
                string.Join(" + ", solution) + " = " + targetSum).ToList();
        }

        private static List<List<decimal>> FindSubsets(List<decimal> numbers, decimal target)
        {
            var solutions = new List<List<decimal>>();
            int numOfSubsets = 1 << numbers.Count;

            for (int subsetMask = 0; subsetMask < numOfSubsets; subsetMask++)
            {
                var currentSubset = new List<decimal>();
                for (int j = 0; j < numbers.Count; j++)
                {
                    if ((subsetMask & (1 << j)) != 0)
                    {
                        currentSubset.Add(numbers[j]);
                    }
                }

                if (currentSubset.Sum() == target)
                {
                    solutions.Add(currentSubset);
                }
            }

            return solutions;
        }
    }
}
