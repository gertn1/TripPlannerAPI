using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public class NotFoundExepetion : JourneyException
    {
        public NotFoundExepetion(string message) : base(message)
        {
        }

        public override HttpStatusCode GetStatusCode()
        {
         return HttpStatusCode.NotFound;
        }
    }
}
