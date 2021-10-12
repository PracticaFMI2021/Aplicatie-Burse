using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class ImportSecretar
    {
        public string CodMatricol { get; set; }
        public double? MedieGenAnAnterior { get; set; }
        public double? MedieGenSemAnterior { get; set; }
        public double? MedieAdmitere { get; set; }
        public double? MedieBac { get; set; }

        public virtual Student CodMatricolNavigation { get; set; }
    }
}
