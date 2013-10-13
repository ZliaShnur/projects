using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Top10AppServices.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        protected const string UuIdHeaderKey = "x-phone-uuid";

        protected string GetPhoneUUID()
        {
            if (!this.Request.Headers.Contains(UuIdHeaderKey))
            {
                throw new ArgumentNullException("No uuid provided");
            }

            var uuid = this.Request.Headers.GetValues(UuIdHeaderKey).First();
            return uuid;
        }

        protected T ExecuteOperationOrHandleExceptions<T>(Func<T> operation)
        {
            try
            {
                return operation();
            }
            catch (Exception ex)
            {
                var errResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                throw new HttpResponseException(errResponse);
            }
        }

    }
}