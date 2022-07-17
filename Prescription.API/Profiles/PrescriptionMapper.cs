using AutoMapper;
using Prescription.API.DTOs;
using Prescription.API.Models;

namespace Prescription.API.Profiles
{
    public class PrescriptionMapper : Profile
    {
        public PrescriptionMapper()
        {
            //source to destination mapping
            CreateMap<PatientPrescription,PatientsPrescriptionsDTO >().ReverseMap(); //reverse so the both direction
        }
    }
}
