using System.Globalization;

namespace SUBSET_SUM_CALC
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource;
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

        private async void Calculate_Click(object sender, EventArgs e)
        {
            decimal? targetSum = TryParseTextBox(ValueToSearch);

            if (!targetSum.HasValue)
                return;

            // Disable the Calculate button and input RichTextBox
            Calculate_btn.Enabled = false;
            Input.Enabled = false;

            // Initialize the cancellation token source
            _cancellationTokenSource = new CancellationTokenSource();

            Output.Clear();
            string inputText = Input.Text;

            try
            {
                await Task.Run(() => SubsetSumSolver.Solve(inputText, targetSum.Value, Output, _cancellationTokenSource.Token, progressBar));
            }
            catch (OperationCanceledException)
            {
                Output.AppendText("Operation was cancelled.\n");
            }
            finally
            {
                // Re-enable the Calculate button and input RichTextBox
                Calculate_btn.Enabled = true;
                Input.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
        }
    }
}