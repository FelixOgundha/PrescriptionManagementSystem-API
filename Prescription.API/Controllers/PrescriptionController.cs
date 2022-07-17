using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prescription.API.Data;
using Prescription.API.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prescription.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly IMapper _mapper;

        public PrescriptionController(IPrescriptionRepository prescriptionRepository, IMapper mapper)
        {
            this._prescriptionRepository = prescriptionRepository;
            this._mapper = mapper;
        }
        // GET: api/<PrescriptionController>
        [HttpGet]
        public IEnumerable<PatientsPrescriptionsDTO> Get()
        {
            var prescriptions = _prescriptionRepository.GetAll();

            if (prescriptions == null)
            {
                return NotFound();
            }

            var result = _mapper.Map<PatientsPrescriptionsDTO>(prescriptions);

            return Ok(result);
        }

     
    }
}
