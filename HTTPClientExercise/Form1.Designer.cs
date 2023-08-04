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
            AddButton = new Button();
            SuspendLayout();
            // 
            // FirstNumberBox
            // 
            FirstNumberBox.Location = new Point(323, 105);
            FirstNumberBox.Name = "FirstNumberBox";
            FirstNumberBox.Size = new Size(100, 23);
            FirstNumberBox.TabIndex = 0;
            // 
            // SecondNumberBox
            // 
            SecondNumberBox.Location = new Point(323, 176);
            SecondNumberBox.Name = "SecondNumberBox";
            SecondNumberBox.Size = new Size(100, 23);
            SecondNumberBox.TabIndex = 1;
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
            label2.Location = new Point(237, 176);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "2nd Number";
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(347, 237);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(48, 15);
            OutputLabel.TabIndex = 4;
            OutputLabel.Text = "Output:";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(231, 233);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
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
        private Button AddButton;
    }
}