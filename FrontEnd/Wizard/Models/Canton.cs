using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Wizard.Models
{
    public partial class Canton
    {
        public int CodigoCanton { get; set; }
        public int CodigoProvincia { get; set; }
        public string NombreCanton { get; set; }

        public virtual Provincia CodigoProvinciaNavigation { get; set; }
    }
}
