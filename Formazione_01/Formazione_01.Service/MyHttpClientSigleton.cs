using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Formazione_01.Service
{
    public class HttpClientSingleton 
    {
        private static HttpClient _httpClient = null;
        private static readonly string baseUrl = ConfigurationManager.AppSettings["APIUrl"];

        protected HttpClientSingleton()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseUrl);

        }

        public static HttpClient httpClient
        {
            get
            {
                if(_httpClient == null)
                {
                     new HttpClientSingleton();
                }
                return _httpClient;

            }
        }
    }
}
