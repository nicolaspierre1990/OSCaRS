using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OSCaRS.Base.Entity;

namespace OSCaRS.Interfaces.Context
{
    public interface IOSCaRSContext
    {
        int SaveChanges();
        void MarkAsModified(EntityBase item);
    }
}
