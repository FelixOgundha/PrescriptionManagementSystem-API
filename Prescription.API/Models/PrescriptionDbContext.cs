using Microsoft.EntityFrameworkCore;

namespace Prescription.API.Models
{
    public class PrescriptionDbContext : DbContext
    {
        public PrescriptionDbContext(DbContextOptions<PrescriptionDbContext> options)
            : base(options)
        {
                
        }

        public DbSet<PatientPrescription> PatientPrescriptions { get; set; }
    }
}
