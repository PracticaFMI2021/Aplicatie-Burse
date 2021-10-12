using System;
using System.Collections.Generic;

#nullable disable

namespace BurseFMI.dbModels
{
    public partial class InfoEvaluareSolicitare
    {
        public string CodMatricol { get; set; }
        public string CodBursa { get; set; }
        public string Email { get; set; }
        public string Observatii { get; set; }
        public DateTime? DataUltimeiRecenzii { get; set; }

        public virtual Solicitare Cod { get; set; }
        public virtual Membru EmailNavigation { get; set; }
    }
}
