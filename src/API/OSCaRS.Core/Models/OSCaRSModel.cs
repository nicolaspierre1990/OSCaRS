using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OSCaRS.Core.Models
{
    public class OSCaRSModel
    {
        private string empty;
        private HttpStatusCode oK;

        public OSCaRSModel(string empty, HttpStatusCode oK)
        {
            this.empty = empty;
            this.oK = oK;
        }
    }
}
