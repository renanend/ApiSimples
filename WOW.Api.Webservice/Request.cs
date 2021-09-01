using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOW.Api.Webservice
{
    public class Request
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
