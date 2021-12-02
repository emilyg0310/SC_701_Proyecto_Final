﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P.API.Models
{
    public class Materiales
    {
        public Materiales()
        {
            
        }

        public int IdMaterial { get; set; }
        public string NombreMaterial { get; set; }
        public decimal CantiMetro { get; set; }

        public virtual ICollection<CalculoMateri> CalculoMateri { get; set; }
    }
}
