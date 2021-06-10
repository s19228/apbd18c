using APBD6CodeFirstMVSv2.Models;
using APBD6CodeFirstMVSv2.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Sql;
using Microsoft.EntityFrameworkCore;

namespace APBD6CodeFirstMVSv2.Repositories.Implementations
{
    public class DoctorDbRepository : IDoctorDbRepository
    {
        private readonly Context _context;  

        public DoctorDbRepository(Context context)
        {
            _context = context;
        }
        public async Task<ICollection<Doctor>> GetDoctorsFromDbAsync()
        {
            return await _context.Doctor.ToListAsync();
        }

        public async Task<Doctor> GetDoctorFromDbAsync(int idDoctor)
        {
            return await _context.Doctor.SingleOrDefaultAsync(d => d.IdDoctor == idDoctor);
                     
        }

        public Task<bool> AddDoctorAsync(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDoctorAsync(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDoctorAsync(int idDoctor)
        {
            throw new NotImplementedException();
        }
    }
}
