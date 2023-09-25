using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace SUBSET_SUM_CALC
{
    public class SubsetSumSolver
    {
        public static void Solve(string inputText, decimal targetSum, RichTextBox output, CancellationToken cancellationToken, ProgressBar progressBar)
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

            progressBar.Invoke(new Action(() => progressBar.Maximum = numbers.Count));

            FindSubsets(numbers, targetSum, new List<decimal>(), 0, output, cancellationToken, progressBar);

            int lineCount = 0;
            output.Invoke(new Action(() =>
            {
                lineCount = output.Lines.Length;
            }));

            if (lineCount == 0) // Check if the RichTextBox is empty
            {
                output.Invoke(new Action(() =>
                {
                    output.AppendText("No combinations found.\n");
                }));
            }
        }




        private static void FindSubsets(List<decimal> numbers, decimal target, List<decimal> currentSubset, int index, RichTextBox output, CancellationToken cancellationToken, ProgressBar progressBar)
        {
            // Check for cancellation
            cancellationToken.ThrowIfCancellationRequested();
            if (index == numbers.Count)
            {
                if (Math.Abs(currentSubset.Sum() - target) < 0.0001M)
                {
                    // Update the RichTextBox with the found solution
                    output.Invoke(new Action(() =>
                    {
                        output.AppendText(string.Join(" + ", currentSubset) + " = " + target + "\n");
                    }));
                }
                return;
            }
            // Update the progress bar
            progressBar.Invoke(new Action(() => progressBar.Value = index));

            // Include the current number in the subset
            currentSubset.Add(numbers[index]);
            FindSubsets(numbers, target, currentSubset, index + 1, output, cancellationToken, progressBar);

            // Exclude the current number from the subset
            currentSubset.RemoveAt(currentSubset.Count - 1);
            FindSubsets(numbers, target, currentSubset, index + 1, output, cancellationToken, progressBar);

        }
    }
}
