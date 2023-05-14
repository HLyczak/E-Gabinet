using System.ComponentModel.DataAnnotations;

namespace Egabinet.Models
{
    public class TimeSheetViewModel
    {
        [Display(Name = "Patient Name")]
        public string Patient { get; set; }

        [Display(Name = "Doctor Name")]
        public string Doctor { get; set; }

        [Display(Name = "Room Number")]
        public long Room { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }


        [Display(Name = "Id")]
        public string Id { get; set; }


        [Display(Name = "Price")]
        public decimal Amount { get; set; }

        [Display(Name = "PaymentId")]
        public string? PaymentId { get; set; }

    }
}
