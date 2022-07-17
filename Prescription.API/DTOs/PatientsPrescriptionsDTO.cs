namespace Prescription.API.DTOs
{
    public class PatientsPrescriptionsDTO
    {  
        public string PatientName { get; set; }
        public decimal Amount { get; set; }
        public int Frequency { get; set; }
    }
}
