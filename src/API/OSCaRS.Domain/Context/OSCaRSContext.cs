using Microsoft.EntityFrameworkCore;

namespace OSCaRS.Domain.Context
{
    public class OSCaRSContext : DbContext
    {
        #region DbSets

        public DbSet<Product> Products { get; set; }

        #endregion

        public OSCaRSContext(DbContextOptions<OSCaRSContext> options)
            : base(options)
        {

        }

        public OSCaRSContext()
        {

        }
    }
}
