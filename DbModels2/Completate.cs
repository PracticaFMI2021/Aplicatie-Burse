using System;
using System.Collections.Generic;
using System.Collections;

#nullable disable

namespace BurseFMI.dbModels
{
    public partial class Completate
    {
        public string CodMatricol { get; set; }
        
        public int? AnInmatriculare { get; set; }
        public int? VenitLunarMembru { get; set; }
        public int? VenitLunarMembruSecretar { get; set; }
        public BitArray ContributiiStiintifice { get; set; }
        public BitArray DiplomePremii { get; set; }
        
        public string AcordGdpr { get; set; }
        public string NumeArhivaDocsSociala { get; set; }
        public string CaleArhiva { get; set; }
        public string TipArhiva { get; set; }
        public string Cnp { get; set; }
        public string AlteDetalii { get; set; }
        public string Iban { get; set; }
        public string NumeFisierExtrasCont { get; set; }
        public string CaleExtrasCont { get; set; }

        public virtual Student CodMatricolNavigation { get; set; }
    }
}
