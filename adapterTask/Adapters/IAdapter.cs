using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterTask.Adapters
{
    interface IAdapter
    {
        public bool MakeCall(string url);
    }
}
