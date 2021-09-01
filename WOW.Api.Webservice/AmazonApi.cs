using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WOW.Api.Webservice
{
    public class AmazonApi
    {
        public static string RetornaTexto()
        {
            string URI = "http://ec2-52-91-68-80.compute-1.amazonaws.com:8000/api/test";
            string response = string.Empty;
            string request = JsonConvert.SerializeObject(new Request() { Nome = "Daniel" });
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                response = wc.UploadString(URI, "POST", request);
            }
            return response;
        }
    }
}
