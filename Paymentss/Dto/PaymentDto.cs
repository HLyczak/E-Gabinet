using Payments.Domains;
using System.ComponentModel.DataAnnotations;

namespace Payments.Dto
{
    public class PaymentDto
    {

        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }


        [Required]
        [Display(Name = "UserId")]
        public string UserId { get; set; }


        [Required]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }



        [Required]
        [Display(Name = "Type")]
        public PaymentType Type { get; set; }

    }
}
