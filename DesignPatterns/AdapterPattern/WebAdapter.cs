using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace DesignPatterns.AdapterPattern
{
    public class WebAdapter : WebRequester
    {
        private HttpClient service;

        public void Connect(HttpClient currSvc)
        {
            this.service = currSvc;
        }
        public int Request(object request)
        {
            var result = JsonConvert.SerializeObject(request);
            var response = service.GetAsync(result);
            if (response != null)
            {
                return 200;
            }
            return 500;
        }
    }
}
