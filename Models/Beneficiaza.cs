using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Beneficiaza
    {
        public string CodMatricol { get; set; }
        public string CodBursa { get; set; }
        public DateTime? DataValidare { get; set; }
        public string NumeFisierDeclAcceptare { get; set; }
        public string CaleFisier { get; set; }

        public virtual Bursa CodBursaNavigation { get; set; }
        public virtual Student CodMatricolNavigation { get; set; }
    }
}
