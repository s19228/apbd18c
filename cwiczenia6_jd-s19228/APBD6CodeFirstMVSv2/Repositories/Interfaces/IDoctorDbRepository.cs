using APBD6CodeFirstMVSv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD6CodeFirstMVSv2.Repositories.Interfaces
{
    public interface IDoctorDbRepository
    {
        Task<ICollection<Doctor>> GetDoctorsFromDbAsync();
        Task<Doctor> GetDoctorFromDbAsync(int idDoctor);
        Task<bool> AddDoctorAsync(Doctor doctor);
        Task<bool> UpdateDoctorAsync(Doctor doctor);
        Task<bool> DeleteDoctorAsync(int idDoctor);
    }
}
