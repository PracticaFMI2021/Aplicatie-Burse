using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Acordum
    {
        public string CodCriteriu { get; set; }
        public string CodBursa { get; set; }

        public virtual Bursa CodBursaNavigation { get; set; }
        public virtual Criteriu CodCriteriuNavigation { get; set; }
    }
}
