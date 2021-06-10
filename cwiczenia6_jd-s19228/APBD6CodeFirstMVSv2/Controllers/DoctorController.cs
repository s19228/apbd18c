using APBD6CodeFirstMVSv2.Models;
using APBD6CodeFirstMVSv2.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APBD6CodeFirstMVSv2.Controllers
{
    
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorDbRepository _doctorDbRepository;

        public DoctorController(IDoctorDbRepository doctorDbRepository)
        {
            _doctorDbRepository = doctorDbRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            ICollection<Doctor> doctors = await _doctorDbRepository.GetDoctorsFromDbAsync(); 
           
            return Ok(doctors);
        }

        [HttpGet("{idDoctor}")]
        public async Task<IActionResult> GetBookById(int idDoctor)
        {
            Doctor doctor = await _doctorDbRepository.GetDoctorFromDbAsync(idDoctor);

            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> AddDoctor(Doctor doctor)
        {
            var isDoctorAdded = await _doctorDbRepository.AddDoctorAsync(doctor);

            if (!isDoctorAdded)
            {
                return BadRequest("Doctor is no added to DB");
            }

            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut("{idDoctor}")]
        public async Task<IActionResult> UpdateDoctor(Doctor doctor)
        {
            var isDoctorUpdatedSucc = await _doctorDbRepository.UpdateDoctorAsync(doctor);

            if (!isDoctorUpdatedSucc)
            {
                return NotFound("No such Doctor in DB");
            }

            return NoContent();
        }

        [HttpDelete("{idDoctor}")]
        public async Task<IActionResult> DeleteDoctor(int idDoctor)
        {
            var isDoctorDeletedSucc = await _doctorDbRepository.DeleteDoctorAsync(idDoctor);

            if (!isDoctorDeletedSucc)
            {
                return NotFound("No such Doctor in DB");
            }

            return NoContent();
        }

    }
}
