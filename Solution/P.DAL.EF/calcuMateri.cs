using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace P.DAL.EF
{
    public partial class CalculoDbContext : DbContext
    {
        public CalculoDbContext()
        {
        }

        public CalculoDbContext(DbContextOptions<CalculoDbContext> options)
            : base(options)
        {
        }
    }
}
