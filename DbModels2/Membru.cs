using System;
using System.Collections.Generic;

#nullable disable

namespace BurseFMI.dbModels
{
    public partial class Membru
    {
        public Membru()
        {
            InfoEvaluareSolicitares = new HashSet<InfoEvaluareSolicitare>();
        }

        public string Email { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public string CodComisie { get; set; }

        public virtual Comisie CodComisieNavigation { get; set; }
        public virtual ICollection<InfoEvaluareSolicitare> InfoEvaluareSolicitares { get; set; }
    }
}
