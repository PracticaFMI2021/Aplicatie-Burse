using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Student
    {
        public Student()
        {
            Beneficiazas = new HashSet<Beneficiaza>();
            Contesta = new HashSet<Contestum>();
            Solicitares = new HashSet<Solicitare>();
        }

        public string CodMatricol { get; set; }
        public string Nume { get; set; }
        public string InitialaTata { get; set; }
        public string Prenume { get; set; }
        public int? AnCurent { get; set; }
        public int? GrupaCurenta { get; set; }
        public string Acronim { get; set; }

        public virtual Specializare AcronimNavigation { get; set; }
        public virtual Completate Completate { get; set; }
        public virtual ImportSecretar ImportSecretar { get; set; }
        public virtual ICollection<Beneficiaza> Beneficiazas { get; set; }
        public virtual ICollection<Contestum> Contesta { get; set; }
        public virtual ICollection<Solicitare> Solicitares { get; set; }
    }
}
