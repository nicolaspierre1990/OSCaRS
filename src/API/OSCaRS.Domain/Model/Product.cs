using OSCaRS.Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSCaRS.Domain.Model
{
    public class Product : EntityBase
    {
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
    }
}
