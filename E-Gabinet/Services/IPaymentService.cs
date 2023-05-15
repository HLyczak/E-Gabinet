using Egabinet.Models;

namespace Egabinet.Services
{
    public interface IPaymentService
    {
        public Task<PaymentDto> AddAsync(AddPaymentDto addPaymentDto);
        public Task<IEnumerable<PaymentDto>> GetAllAsync();
    }
}
