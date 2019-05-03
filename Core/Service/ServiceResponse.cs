using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Core.Service
{
    [Serializable]
    public class Response<T>
    {               
        public IList<T> List { get; set; }

        [JsonProperty]
        public T Entity { get; set; }

        public int Count { get; set; }

        public bool IsSuccessful { get; set; }

        public Response(HttpContext context)
        {
            List = new List<T>();
        }
    }
}
