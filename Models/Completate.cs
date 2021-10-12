using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Completate
    {
        public string CodMatricol { get; set; }
        public string Email { get; set; }
        public int? AnInmatriculare { get; set; }
        public int? VenitLunarMembru { get; set; }
        public int? VenitLunarMembruSecretar { get; set; }
        public bool? ContributiiStiintifice { get; set; }
        public bool? DiplomePremii { get; set; }
        public bool? AcordGdpr { get; set; }
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
