using System;
using System.Collections.Generic;

#nullable disable

namespace BurseFMI.dbModels
{
    public partial class Bursa
    {
        public Bursa()
        {
            Acorda = new HashSet<Acordum>();
            Beneficiazas = new HashSet<Beneficiaza>();
            Contesta = new HashSet<Contesta>();
            Solicitares = new HashSet<Solicitare>();
        }

        public string Cod { get; set; }
        public string Tip { get; set; }
        public DateTime? DataLimitaSolicitare { get; set; }
        public DateTime? DataLimitaRecenzie { get; set; }
        public DateTime? DataLimitaContestatie { get; set; }
        public DateTime? DataInceput { get; set; }
        public DateTime? DataFinal { get; set; }
        public string Descriere { get; set; }
        public double? Suma { get; set; }
        public double? Buget { get; set; }
        public int? NrBurse { get; set; }
        public string CodComisie { get; set; }

        public virtual Comisie CodComisieNavigation { get; set; }
        public virtual ICollection<Acordum> Acorda { get; set; }
        public virtual ICollection<Beneficiaza> Beneficiazas { get; set; }
        public virtual ICollection<Contesta> Contesta { get; set; }
        public virtual ICollection<Solicitare> Solicitares { get; set; }
    }
}
