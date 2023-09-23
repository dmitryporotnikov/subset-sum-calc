using System.Globalization;

namespace SUBSET_SUM_CALC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal? TryParseTextBox(TextBox textBox)
        {
            if (decimal.TryParse(textBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("The value should be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return null;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal? targetSum = TryParseTextBox(ValueToSearch); // Replace 'yourTextBoxName' with the name of your TextBox

            if (!targetSum.HasValue)
                return;

            Output.Clear();
            var results = SubsetSumSolver.Solve(Input.Text, targetSum.Value);

            foreach (var result in results)
            {
                Output.AppendText(result + "\n");
            }
        }
    }
}