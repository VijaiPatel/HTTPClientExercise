namespace HTTPClientExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // convert string to int
            int a = Convert.ToInt32(FirstNumberBox.Text);
            int b =Convert.ToInt32(SecondNumberBox.Text);
            // add numbers together
            int c = a+b;
            OutputLabel.Text = c.ToString();//convert int to string to display in label
        }
    }
}