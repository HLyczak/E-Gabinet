using Core.Domain;
using Core.Repositories;
using Egabinet.Models;
using Newtonsoft.Json;
using System.Text;

namespace Egabinet.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient httpClient;
        private readonly ITimesheetRepository timesheetRepository;

        public PaymentService(HttpClient httpClient, ITimesheetRepository timesheetRepository)
        {
            this.httpClient = httpClient;
            this.timesheetRepository = timesheetRepository;
        }



        public async Task<PaymentDto?> AddAsync(AddPaymentDto addPaymentDto)
        {
            TimeSheet timesheet = await timesheetRepository.GetByIdAsync(addPaymentDto.TimesheetId);

            string json = JsonConvert.SerializeObject(new { UserId = timesheet.PatientId, timesheet.Amount, addPaymentDto.Type });
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync("api/Payment", data);
            string result = await response.Content.ReadAsStringAsync();

            PaymentDto? payment = JsonConvert.DeserializeObject<PaymentDto>(result);
            timesheet.PaymentId = payment.Id;

            TimeSheet timesheeupdate = await timesheetRepository.UpdateAsync(timesheet);

            return payment;
        }


        public async Task<IEnumerable<PaymentDto>> GetAllAsync()
        {
            HttpResponseMessage response = await httpClient.GetAsync("api/Payment");
            if (response.IsSuccessStatusCode)
            {

                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<PaymentDto>>(content);
            }
            throw new ApplicationException($"Status code: {response.StatusCode}, Error:{response.ReasonPhrase}");

        }

    }
}

