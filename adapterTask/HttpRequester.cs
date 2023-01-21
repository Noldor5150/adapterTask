using adapterTask.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterTask
{
    class HttpRequester
    {
        private readonly IAdapter adapter;

        public HttpRequester(IAdapter Adapter)
        {
            adapter = Adapter;
        }


        public bool Fetch(string url)

        {
            adapter.MakeCall(url);
            return true;
        }
    }
}
