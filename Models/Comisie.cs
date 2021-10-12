using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Comisie
    {
        public Comisie()
        {
            Bursas = new HashSet<Bursa>();
            Membrus = new HashSet<Membru>();
        }

        public string CodComisie { get; set; }
        public string Nume { get; set; }

        public virtual ICollection<Bursa> Bursas { get; set; }
        public virtual ICollection<Membru> Membrus { get; set; }
    }
}
