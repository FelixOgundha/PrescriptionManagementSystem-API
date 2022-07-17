using System.ComponentModel.DataAnnotations;

namespace Prescription.API.Models
{
    public class PatientPrescription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PatientName { get; set; }

        [Required(ErrorMessage ="Baaanage Amount is required")]
        public decimal Amount { get; set; }
        public int Frequency { get; set; }

    }
}
