using System;
using Microsoft.EntityFrameworkCore;
using OSCaRS.Domain.Model;
using OSCaRS.Interfaces.Context;
using OSCaRS.Base.Entity;

namespace OSCaRS.Domain.Context
{
    public class OSCaRSContext : DbContext, IOSCaRSContext
    {
        #region DbSets

        public DbSet<Product> Products { get; set; }

        #endregion

        #region Constructor

        public OSCaRSContext(DbContextOptions<OSCaRSContext> options)
            : base(options)
        {

        }

        public OSCaRSContext()
        {

        }

        #endregion

        public void MarkAsModified(EntityBase item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
