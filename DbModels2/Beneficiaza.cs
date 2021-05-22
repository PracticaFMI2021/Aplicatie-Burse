using System;
using System.Collections.Generic;
using System.Collections;
#nullable disable
namespace BurseFMI.dbModels
{
    public partial class Beneficiaza
    {
        public string CodMatricol { get; set; }
        public string CodBursa { get; set; }
        public DateTime? DataValidare { get; set; }
        public string NumeFisierDeclAcceptare { get; set; }
        public BitArray CaleFisier { get; set; }

        public virtual Bursa CodBursaNavigation { get; set; }
        public virtual Student CodMatricolNavigation { get; set; }
    }
}
