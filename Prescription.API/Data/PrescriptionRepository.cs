using Prescription.API.Models;

namespace Prescription.API.Data
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly PrescriptionDbContext _context;

        public PrescriptionRepository(PrescriptionDbContext context)
        {
            this._context = context;
        }

        public void Create(PatientPrescription prescription)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PatientPrescription Get(int id)
        {
            return _context.PatientPrescriptions.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<PatientPrescription> GetAll()
        {
            return _context.PatientPrescriptions.ToList();
        }

        public void Update(PatientPrescription prescription)
        {
            throw new NotImplementedException();
        }
    }
}
