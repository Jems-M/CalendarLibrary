using System.Text.Json;
using System.Text;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace CalendarForm
{
    public partial class Form1 : Form
    {
        static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        // on selecting a day in the calendar
        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string url = "https://localhost:44343/api/Event/";
            string date = e.End.ToString();
            string fullUrl = $"{url}?date={Uri.EscapeDataString(date)}";

            // get the day's events from the DB
            HttpResponseMessage response = await client.GetAsync(fullUrl);
            response.EnsureSuccessStatusCode();

            // reformat the DB's response to remove square brackets and
            // print each entry on a new line
            string responseBody = await response.Content.ReadAsStringAsync();
            string[] stringArray = JsonSerializer.Deserialize<string[]>(responseBody);

            txt_eventOutput.Text = String.Join(Environment.NewLine, stringArray);
        }

        // Add new event button
        private async void button1_Click(object sender, EventArgs e)
        {
            // all times on the DB are 23:59:59
            DateTime adjustedDt = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                23, 59, 59
                );
            var newEvent = new {
                date = adjustedDt.ToString(),
                name = txt_newEventName.Text
            };

            var json = JsonSerializer.Serialize(newEvent);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            string url = "https://localhost:44343/api/Event/add";
            
            await client.PostAsync(url, data);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_eventOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
