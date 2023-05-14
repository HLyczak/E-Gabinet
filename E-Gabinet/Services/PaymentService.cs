
using Egabinet.Models;
using Newtonsoft.Json;

namespace Egabinet.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient httpClient;
        public PaymentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }



        public Task<PaymentDto> AddAsync(AddPaymentDto addPaymentDto)
        {
            throw new NotImplementedException();
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

        public Task<PaymentDto?> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
