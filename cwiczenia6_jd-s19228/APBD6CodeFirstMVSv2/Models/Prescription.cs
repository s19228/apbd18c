using APBD6CodeFirstMVS2.Models;
using System;
using System.Collections.Generic;

namespace APBD6CodeFirstMVSv2.Models
{
    public class Prescription
    {
        
        public Prescription()
        {
            PrescriptoinsMedicaments = new HashSet<PrescriptionMedicament>();
        }
        
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        
        public virtual Doctor IdDoctorNavigation{ get; set; }
        public virtual Patient IdPatientNavigation{ get; set; }
        public virtual ICollection<PrescriptionMedicament> PrescriptoinsMedicaments{ get; set; }

    }
}