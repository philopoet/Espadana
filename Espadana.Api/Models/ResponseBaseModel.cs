using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Espadana.Api.Models
{
    public class ResponseBaseModel<TKey>
    {
        public TKey Id { get; set; }
        public HttpStatusCode ReposneStatus { get; set; }
    }
}
