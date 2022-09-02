using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Formazione_01.Domain;
using System.Web.Script.Serialization;
using Flurl;
using Flurl.Http;
using System.Configuration;

namespace Formazione_01.Service
{
    public class MyAPIClient
    {

        private readonly string _url = ConfigurationManager.AppSettings["APIUrl"];

        public List<T> Get <T> (string endpoint) 
        {
            return _url.AppendPathSegment(endpoint).GetJsonAsync<List<T>>().Result;
        }



        public  T Get <T> (string endpoint, string id)
        {
            return _url.AppendPathSegment(endpoint + "/" + id).GetJsonAsync<T>().Result;
        }



        public bool Post <T> (string endpoint, T item)
        { 
            var post = _url.AppendPathSegment(endpoint).PostJsonAsync(item).Result;
            return true;
        }

        public bool Put<T>(string endpoint, T item)
        {
            var post = _url.AppendPathSegment(endpoint).PutJsonAsync(item).Result;
            return true;
        }

        public List<string> GetMachinesCodeExcepted (string endpoint, string id)
        {
            return _url.AppendPathSegment(endpoint + "/" + id + "/CodeExcepted").GetJsonAsync<List<string>>().Result;
        }

        public List<Tool> GetToolsByPartialId(string endpoint, string id)
        {
            return _url.AppendPathSegment(endpoint + "/ByPartialId/" + id).GetJsonAsync<List<Tool>>().Result;
        }


        public static class CONTROLLER
        {
            public static string Machines
            {
                get { return "api/Machines"; }
            }
            public static string Tools
            {
                get { return "api/Tools"; }
            }

            public static string ToolMachine
            {
                get { return "api/ToolMachine"; }
            }

            public static string Turret
            {
                get { return "api/Turret"; }
            }
        }


    }
}
