using Microsoft.EntityFrameworkCore;
using OScaRS.Data.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSCaRS.Data.EntityFramework.Contexts
{
    public class OscarsContext : DbContext
    {
        #region DbSets

        public DbSet<Product> Products { get; set; }

        #endregion

        public OscarsContext(DbContextOptions<OscarsContext> options)
            : base(options)
        {

        }
    }
}
