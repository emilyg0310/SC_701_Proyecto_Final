using System;
using System.Collections.Generic;
using System.Text;

namespace P.DAL.DO.Objects
{
    public partial class Canton
    {
        public Canton()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int CodigoCanton { get; set; }
        public int CodigoProvincia { get; set; }
        public string NombreCanton { get; set; }

        public virtual Provincia CodigoProvinciaNavigation { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
