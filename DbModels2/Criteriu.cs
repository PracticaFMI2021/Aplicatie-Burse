using System;
using System.Collections.Generic;

#nullable disable

namespace BurseFMI.dbModels
{
    public partial class Criteriu
    {
        public Criteriu()
        {
            Acorda = new HashSet<Acordum>();
        }

        public string CodCriteriu { get; set; }
        public string Descriere { get; set; }

        public virtual ICollection<Acordum> Acorda { get; set; }
    }
}
