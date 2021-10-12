using System;
using System.Collections.Generic;

#nullable disable

namespace BurseFMI.dbModels
{
    public partial class Specializare
    {
        public Specializare()
        {
            Students = new HashSet<Student>();
        }

        public string Acronim { get; set; }
        public string Nume { get; set; }
        public string Domeniu { get; set; }
        public string ProgramStudii { get; set; }
        public int? NrStudenti { get; set; }
        public int? NrPromovati { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
