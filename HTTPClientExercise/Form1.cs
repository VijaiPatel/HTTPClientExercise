using System.Net.Http.Json;
using System.Security.Policy;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;

namespace HTTPClientExercise
{
    public partial class Form1 : Form
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operator { get; set; }
        static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            CalcButton.Enabled = false;
        }
        // combobox slected index changed event handler
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operator = comboBox1.Text;
            CalcButton.Enabled = !string.IsNullOrEmpty(Operator);
        }
        //FirstNumberBox TextChanged event handler
        private void FirstNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(FirstNumberBox.Text, out double result))
            {
                Num1 = result;
            }
            else
            {
                MessageBox.Show("Not a valid number, please enter a valid number");
                FirstNumberBox.Clear();
            }
        }
        //SecondNumberBox TextChanged event handler
        private void SecondNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(SecondNumberBox.Text, out double result))
            {
                Num2 = result;

                if (Operator == "/" && Num2 == 0)
                {
                    MessageBox.Show("Unable to divide by 0");
                    SecondNumberBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Not a valid number, please enter a valid number");
                SecondNumberBox.Clear();
            }
        }
        //button click event handler
        private async void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                double result = await Post_API(Num1, Num2, Operator);
                MessageBox.Show($"Result: {result}\n\nOperation was successfull.", "Calculation Result and Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occcured: {ex.Message}", "Error");
            }
        }

        //post request to api to perform an operation and return a result
        private async Task<double> Post_API(double num1, double num2, string operation)
        {
            var requestData = new
            {
                Num1 = num1,
                Num2 = num2,
                Operator = operation
            };

            HttpResponseMessage response = await client.PostAsJsonAsync("http://localhost:5045/api/calcs", requestData);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                CalcResponse calcResponse = JsonConvert.DeserializeObject<CalcResponse>(responseBody);
                return calcResponse.Result;
            }
            else
            {
                throw new Exception($"Failed to request API, status code:{response.StatusCode}");
            }
        }
        //gets calc history from the api

        private async Task<List<CalcResults>> Get_API()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost5045/api/calcs");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                List<CalcResults> calc = JsonConverter.DeserializeObject<List<CalcResults>>(responseBody);

                return calc;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error has occured: {ex.Message}", "Error");
                return null;
            }
        }
        //History Button click event handler
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<CalcResults> calc = await Get_API();
                if (calc != null && calc.Count >0)
                {
                    CalcHistory calcHistoryform = new CalcHistory(calc);
                    //create popup
                    calcHistoryform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No History Available", "Info");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error has occured: {ex.Message}", "Error");
            }
        }
    }
}


