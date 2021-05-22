using System;
using System.Collections.Generic;

#nullable disable

namespace BurseFMI.dbModels
{
    public partial class Student
    {
        public Student()
        {
            Beneficiazas = new HashSet<Beneficiaza>();
            Contestas = new HashSet<Contesta>();
            Solicitares = new HashSet<Solicitare>();
        }
        public string Email { get; set; }
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
        public virtual ICollection<Contesta> Contestas { get; set; }
        public virtual ICollection<Solicitare> Solicitares { get; set; }
    }
}
