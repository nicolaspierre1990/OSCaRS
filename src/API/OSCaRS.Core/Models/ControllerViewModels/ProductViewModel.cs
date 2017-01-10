using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSCaRS.Core.Models.ControllerViewModels
{
    public class ProductViewModel
    {
    }

    public class AddProductViewModel
    {
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
    }
}
