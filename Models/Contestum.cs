using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Contestum
    {
        public string CodMatricol { get; set; }
        public string CodBursa { get; set; }
        public DateTime? DataContestatie { get; set; }
        public string Motiv { get; set; }
        public string Status { get; set; }
        public string ObservatiiSefComisie { get; set; }

        public virtual Bursa CodBursaNavigation { get; set; }
        public virtual Student CodMatricolNavigation { get; set; }
    }
}
