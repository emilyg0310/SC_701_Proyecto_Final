using System;
using System.Collections.Generic;
using System.Text;

namespace P.DAL.DO.Objects
{
    public partial class Provincia
    {
        public Provincia()
        {
            CantonCr = new HashSet<CantonCr>();
        }

        public short CodigoProvincia { get; set; }
        public string NombreProvincia { get; set; }

        public virtual ICollection<Canton> CantonCr { get; set; }
    }
}
}
