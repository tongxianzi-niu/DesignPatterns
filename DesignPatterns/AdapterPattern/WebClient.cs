using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern
{
    public class WebClient
    {
        private WebRequester webRequester;

        public WebClient(WebRequester webRequester)
        {
            this.webRequester = webRequester;
        }

        private Object MakeObject()
        {
            return (Object)null;
        }

        public void DoWork()
        {
            Object obj = MakeObject();
            int status = webRequester.Request(obj);

            if (status == 200)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Not OK");
            }
        }
    }
}
