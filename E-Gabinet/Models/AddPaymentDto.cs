using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Egabinet.Models
{
    public class AddPaymentDto
    {
        [Required]

        public string UserId { get; set; }

        [Required]
        [Range(1, 999999)]
        public decimal Amount { get; set; }

        [Required]
        public PaymentType Type { get; set; }

        [Required]
        [Display(Name = "Timesheet")]
        public string TimesheetId { get; set; }
        public IEnumerable<SelectListItem> Timesheets { get; set; }
    }
}
