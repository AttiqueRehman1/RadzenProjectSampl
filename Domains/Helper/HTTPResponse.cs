using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helper
{
    public class HTTPResponse
    {
        public class ApiCallResponse
        {
            public HttpStatusCode StatusCode { get; set; }
            public bool IsSuccessStatusCode { get; set; }
            public object ResultData { get; set; } 
        }
      
        public class RequestFailedResponse
        {
            public IEnumerable<String> Errors { get; set; }
            public string ErrorMessage { get; set; }
        }
        public class BadRequestResponse
        {
            public string Message { get; set; }
            public string InnerException { get; set; }
        }
    }
}
