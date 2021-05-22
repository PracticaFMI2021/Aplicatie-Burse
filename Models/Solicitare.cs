using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Solicitare
    {
        public Solicitare()
        {
            InfoEvaluareSolicitares = new HashSet<InfoEvaluareSolicitare>();
        }

        public string CodMatricol { get; set; }
        public string CodBursa { get; set; }
        public DateTime? DataSolicitare { get; set; }
        public DateTime? DataUltimeiModificari { get; set; }
        public string Status { get; set; }
        public string ObservatiiSecretar { get; set; }
        public string ObservatiiSefComisie { get; set; }
        public string DataUltimeiRecenziiSef { get; set; }

        public virtual Bursa CodBursaNavigation { get; set; }
        public virtual Student CodMatricolNavigation { get; set; }
        public virtual ICollection<InfoEvaluareSolicitare> InfoEvaluareSolicitares { get; set; }
    }
}
