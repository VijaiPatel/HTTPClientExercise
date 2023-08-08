namespace HTTPClientExercise
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
            FirstNumberBox = new TextBox();
            SecondNumberBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            OutputLabel = new Label();
            CalcButton = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            HistoryButton = new Button();
            SuspendLayout();
            // 
            // FirstNumberBox
            // 
            FirstNumberBox.Location = new Point(323, 102);
            FirstNumberBox.Name = "FirstNumberBox";
            FirstNumberBox.Size = new Size(121, 23);
            FirstNumberBox.TabIndex = 0;
            FirstNumberBox.TextChanged += FirstNumberBox_TextChanged;
            // 
            // SecondNumberBox
            // 
            SecondNumberBox.Location = new Point(323, 150);
            SecondNumberBox.Name = "SecondNumberBox";
            SecondNumberBox.Size = new Size(121, 23);
            SecondNumberBox.TabIndex = 1;
            SecondNumberBox.TextChanged += SecondNumberBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 105);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "1st Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 153);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "2nd Number";
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(339, 237);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(48, 15);
            OutputLabel.TabIndex = 4;
            OutputLabel.Text = "Output:";
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(237, 233);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(75, 23);
            CalcButton.TabIndex = 5;
            CalcButton.Text = "Calculate";
            CalcButton.UseVisualStyleBackColor = true;
            CalcButton.Click += CalcButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 197);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Operator";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(323, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // HistoryButton
            // 
            HistoryButton.Location = new Point(231, 299);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(75, 23);
            HistoryButton.TabIndex = 9;
            HistoryButton.Text = "History";
            HistoryButton.UseVisualStyleBackColor = true;
            HistoryButton.Click += HistoryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HistoryButton);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(CalcButton);
            Controls.Add(OutputLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SecondNumberBox);
            Controls.Add(FirstNumberBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox FirstNumberBox;
        private TextBox SecondNumberBox;
        private Label label1;
        private Label label2;
        private Label OutputLabel;
        private Button CalcButton;
        private Label label3;
        private ComboBox comboBox1;
        private Button HistoryButton;
    }
}