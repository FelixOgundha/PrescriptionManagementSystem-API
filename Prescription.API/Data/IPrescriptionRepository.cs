using Prescription.API.Models;

namespace Prescription.API.Data
{
    public interface IPrescriptionRepository
    {

        IEnumerable<PatientPrescription> GetAll();

        PatientPrescription Get(int id);
        void Delete(int id);
        void Update(PatientPrescription prescription);
        void Create(PatientPrescription prescription);
    }
}
