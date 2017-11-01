using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace br.procon.si.UAT.Helpers
{
    //https://www.codeproject.com/Articles/1083779/RESTful-Day-sharp-Unit-Testing-and-Integration-T
    public class HttpClientHelper
    {
        private HttpResponseMessage _response;

        public void Enviar(string urlbase, string url, string verboHttp, string corpo)
        {
            var metodo = HttpMethod.Get;
            switch (verboHttp.ToLower())
            {
                case "put":
                    metodo = HttpMethod.Put;
                    break;
            }

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = metodo
            };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlbase);
                _response = client.SendAsync(request).Result;
            }
        }

        public string Token()
        {
            return ((string[])(_response.Headers.GetValues("Token")))[0];
        }

        public int StatusCode()
        {
            return (int)_response.StatusCode;
        }

        public string Corpo()
        {
            return _response.Content.ReadAsStringAsync().Result;
        }
    }
}