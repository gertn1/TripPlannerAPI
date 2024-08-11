using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public class ErrorOnValidationExeception : JourneyException
    {
        public ErrorOnValidationExeception(string message) : base(message)
        {

        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.BadRequest;
        }
    }
}
