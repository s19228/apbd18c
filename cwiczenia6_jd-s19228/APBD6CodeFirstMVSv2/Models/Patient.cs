
using APBD6CodeFirstMVSv2.Models;
using System.Collections.Generic;

namespace APBD6CodeFirstMVS2.Models
{
    public class Patient
    {
        public Patient()
        {
            Prescriptoins = new HashSet<Prescription>();
        }
 
        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDate { get; set; }

        public virtual ICollection<Prescription> Prescriptoins { get; set; }

    }
}