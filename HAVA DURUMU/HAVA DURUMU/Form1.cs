using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace HavaDurumuApp
{
    public partial class Form1 : Form
    {
        private const string apiKey = "d0ced979993849b6bcf175501242012"; 
        private const string baseUrl = "https://api.weatherapi.com/v1/current.json?key=";

        public Form1()
        {
            InitializeComponent();
        }

        private void cityTextBox_Enter(object sender, EventArgs e)
        {
            if (cityTextBox.Text == "Şehir ismi girin")
            {
                cityTextBox.Text = "";
                cityTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void cityTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityTextBox.Text = "Şehir ismi girin";
                cityTextBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private async void getWeatherButton_Click(object sender, EventArgs e)
        {
            string cityName = cityTextBox.Text;
            if (string.IsNullOrEmpty(cityName) || cityName == "Şehir ismi girin")
            {
                MessageBox.Show("Lütfen bir şehir adı girin.");
                return;
            }

            string url = $"{baseUrl}{apiKey}&q={cityName}&lang=tr";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        string errorMessage = $"API'den hata: {response.StatusCode} - {responseBody}";
                        MessageBox.Show(errorMessage);
                        return;
                    }

                    string responseBodySuccess = await response.Content.ReadAsStringAsync();
                    dynamic weatherData = JsonConvert.DeserializeObject(responseBodySuccess);

                    double temperature = weatherData.current.temp_c;
                    string condition = weatherData.current.condition.text;

                    temperatureLabel.Text = $"Sıcaklık: {temperature}°C";
                    conditionLabel.Text = $"Durum: {condition}";
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"İstek hatası: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bilinmeyen hata: {ex.Message}");
                }
            }
        }
    }
}
