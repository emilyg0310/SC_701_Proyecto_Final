using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public partial class CantonCr
    {
        public CantonCr()
        {
            Cliente = new HashSet<Cliente>();
        }

        public short CodigoCanton { get; set; }
        public short CodigoProvincia { get; set; }
        public string NombreCanton { get; set; }

        public virtual ProvinciaCr CodigoProvinciaNavigation { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
