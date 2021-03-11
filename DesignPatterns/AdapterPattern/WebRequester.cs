using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern
{
    public interface WebRequester
    {
        public int Request(Object request);
    }
}
