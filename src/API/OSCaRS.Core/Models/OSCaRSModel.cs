using OSCaRS.Base.Entity;
using System.Net;

namespace OSCaRS.Core.Models
{
    public class OSCaRSModel
    {
        public string ErrorMessage { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public EntityBase Entity { get; set; }

        public OSCaRSModel(string errorMessage, HttpStatusCode statusCode)
        {
            this.ErrorMessage = errorMessage;
            this.StatusCode = statusCode;
        }
    }
}
