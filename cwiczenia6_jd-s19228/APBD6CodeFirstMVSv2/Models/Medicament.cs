﻿using System.Collections.Generic;

namespace APBD6CodeFirstMVSv2.Models
{
    public class Medicament
    {
        public Medicament()
        {
            PrescriptoinsMedicaments = new HashSet<PrescriptionMedicament>();
        }
        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        
        public virtual ICollection<PrescriptionMedicament> PrescriptoinsMedicaments{ get; set; }
    }
}