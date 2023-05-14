using System.ComponentModel.DataAnnotations;

namespace Egabinet.Models
{
    public class PaymentDto
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public PaymentType Type { get; set; }
    }


    public enum PaymentType
    {
        Cash,
        Paycard

    }
}
