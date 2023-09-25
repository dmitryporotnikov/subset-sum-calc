namespace SUBSET_SUM_CALC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Input = new RichTextBox();
            Output = new RichTextBox();
            Calculate_btn = new Button();
            ValueToSearch = new TextBox();
            lbl_value = new Label();
            lbl_input = new Label();
            Stop_btn = new Button();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // Input
            // 
            Input.Location = new Point(17, 50);
            Input.Margin = new Padding(4, 5, 4, 5);
            Input.Name = "Input";
            Input.Size = new Size(1037, 194);
            Input.TabIndex = 0;
            Input.Text = "";
            // 
            // Output
            // 
            Output.Location = new Point(17, 303);
            Output.Margin = new Padding(4, 5, 4, 5);
            Output.Name = "Output";
            Output.Size = new Size(1037, 369);
            Output.TabIndex = 1;
            Output.Text = "";
            // 
            // Calculate_btn
            // 
            Calculate_btn.Location = new Point(709, 254);
            Calculate_btn.Margin = new Padding(4, 5, 4, 5);
            Calculate_btn.Name = "Calculate_btn";
            Calculate_btn.Size = new Size(170, 38);
            Calculate_btn.TabIndex = 2;
            Calculate_btn.Text = "Calculate";
            Calculate_btn.UseVisualStyleBackColor = true;
            Calculate_btn.Click += Calculate_Click;
            // 
            // ValueToSearch
            // 
            ValueToSearch.Location = new Point(269, 258);
            ValueToSearch.Margin = new Padding(4, 5, 4, 5);
            ValueToSearch.Name = "ValueToSearch";
            ValueToSearch.Size = new Size(397, 31);
            ValueToSearch.TabIndex = 3;
            // 
            // lbl_value
            // 
            lbl_value.AutoSize = true;
            lbl_value.Location = new Point(13, 263);
            lbl_value.Margin = new Padding(4, 0, 4, 0);
            lbl_value.Name = "lbl_value";
            lbl_value.Size = new Size(215, 25);
            lbl_value.TabIndex = 4;
            lbl_value.Text = "Value you are looking for:";
            // 
            // lbl_input
            // 
            lbl_input.AutoSize = true;
            lbl_input.Location = new Point(17, 15);
            lbl_input.Margin = new Padding(4, 0, 4, 0);
            lbl_input.Name = "lbl_input";
            lbl_input.Size = new Size(579, 25);
            lbl_input.TabIndex = 5;
            lbl_input.Text = "Input values, space separated. Input decimal values with dot (e.g 19.23):";
            // 
            // Stop_btn
            // 
            Stop_btn.Location = new Point(887, 254);
            Stop_btn.Margin = new Padding(4, 5, 4, 5);
            Stop_btn.Name = "Stop_btn";
            Stop_btn.Size = new Size(147, 39);
            Stop_btn.TabIndex = 6;
            Stop_btn.Text = "Stop";
            Stop_btn.UseVisualStyleBackColor = true;
            Stop_btn.Click += Stop_btn_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(17, 684);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1037, 34);
            progressBar.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 730);
            Controls.Add(progressBar);
            Controls.Add(Stop_btn);
            Controls.Add(lbl_input);
            Controls.Add(lbl_value);
            Controls.Add(ValueToSearch);
            Controls.Add(Calculate_btn);
            Controls.Add(Output);
            Controls.Add(Input);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SUBSET SUM CALC";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Input;
        private RichTextBox Output;
        private Button Calculate_btn;
        private TextBox ValueToSearch;
        private Label lbl_value;
        private Label lbl_input;
        private Button Stop_btn;
        private ProgressBar progressBar;
    }
}