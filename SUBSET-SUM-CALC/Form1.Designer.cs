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
            Input = new System.Windows.Forms.RichTextBox();
            Output = new System.Windows.Forms.RichTextBox();
            Calculate = new System.Windows.Forms.Button();
            ValueToSearch = new System.Windows.Forms.TextBox();
            lbl_value = new System.Windows.Forms.Label();
            lbl_input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            Input.Location = new System.Drawing.Point(12, 30);
            Input.Name = "Input";
            Input.Size = new System.Drawing.Size(727, 166);
            Input.TabIndex = 0;
            Input.Text = "";
            // 
            // Output
            // 
            Output.Location = new System.Drawing.Point(12, 231);
            Output.Name = "Output";
            Output.Size = new System.Drawing.Size(727, 187);
            Output.TabIndex = 1;
            Output.Text = "";
            // 
            // Calculate
            // 
            Calculate.Location = new System.Drawing.Point(583, 202);
            Calculate.Name = "Calculate";
            Calculate.Size = new System.Drawing.Size(153, 23);
            Calculate.TabIndex = 2;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += this.Calculate_Click;
            // 
            // ValueToSearch
            // 
            ValueToSearch.Location = new System.Drawing.Point(191, 203);
            ValueToSearch.Name = "ValueToSearch";
            ValueToSearch.Size = new System.Drawing.Size(338, 23);
            ValueToSearch.TabIndex = 3;
            // 
            // lbl_value
            // 
            lbl_value.AutoSize = true;
            lbl_value.Location = new System.Drawing.Point(12, 206);
            lbl_value.Name = "lbl_value";
            lbl_value.Size = new System.Drawing.Size(141, 15);
            lbl_value.TabIndex = 4;
            lbl_value.Text = "Value you are looking for:";
            // 
            // lbl_input
            // 
            lbl_input.AutoSize = true;
            lbl_input.Location = new System.Drawing.Point(12, 9);
            lbl_input.Name = "lbl_input";
            lbl_input.Size = new System.Drawing.Size(302, 15);
            lbl_input.TabIndex = 5;
            lbl_input.Text = "Input values, space separated. Separate decimals by dot:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 438);
            this.Controls.Add(lbl_input);
            this.Controls.Add(lbl_value);
            this.Controls.Add(ValueToSearch);
            this.Controls.Add(Calculate);
            this.Controls.Add(Output);
            this.Controls.Add(Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUBSET SUM CALC";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private RichTextBox Input;
        private RichTextBox Output;
        private Button Calculate;
        private TextBox ValueToSearch;
        private Label lbl_value;
        private Label lbl_input;
    }
}