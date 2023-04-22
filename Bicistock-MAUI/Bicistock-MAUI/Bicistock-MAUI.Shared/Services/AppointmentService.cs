using Bicistock_MAUI.Bicistock_MAUI.Shared.Models;
using Newtonsoft.Json;

namespace Bicistock_MAUI.Bicistock_MAUI.Shared.Services
{
    public class AppointmentService
    {
        private readonly HttpClient _httpClient;

        public AppointmentService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://192.168.0.19:5000/");
            _httpClient.Timeout = TimeSpan.FromSeconds(10);

        }

        public async Task<List<Appointment>> GetHttpAppointments()
        {
            List<Appointment> appointments = null;
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("api/ConsultaCitas");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
                }
                else
                {
                    Console.WriteLine("Error fetching appointments. Status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching appointments: " + ex.Message);
            }

            return appointments;
        }
    }
}
